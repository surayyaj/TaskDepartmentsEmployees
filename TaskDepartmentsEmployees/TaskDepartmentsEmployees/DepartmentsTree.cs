using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Windows.Forms;
using TaskDepartmentsEmployees.Models;

namespace TaskDepartmentsEmployees
{
    public partial class DepartmentsTree : Form
    {
        private string connectionString;
        private DataContext db;
        private List<Department> departments;
        private List<Employee> employees;
        private EmployeeForm employeeForm;
        public DepartmentsTree()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            db = new DataContext(connectionString);
            departments = db.GetTable<Department>().ToList();
            employees = db.GetTable<Employee>().ToList();
            employeeForm = new EmployeeForm();
            employeeForm.action += PopulateDataGridView;           
            InitializeComponent();
        }

        private void DepartmentsTree_Load(object sender, EventArgs e)
        {
            FillTreeView();           
        }

        private void FillTreeView()
        {
            var company = GetRootDepartment();
            var rootNode = new TreeNode(company.DepartmentName);
            rootNode.Tag = company.Id;
            DepartmentsTreeView.Nodes.Add(rootNode);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(rootNode);
            while (queue.Count != 0)
            {
                var parentNode = queue.Dequeue();
                var parentDepartment = departments.Where(d => d.Id == (Guid)parentNode.Tag).FirstOrDefault();
                var childrenDepartmens = GetChildrenDepartments(parentDepartment);
                var childrenNodes = new TreeNode[childrenDepartmens.Length];
                for (int i = 0; i < childrenDepartmens.Length; i++)
                {                    
                    childrenNodes[i] = new TreeNode(childrenDepartmens[i].DepartmentName);
                    childrenNodes[i].Tag = childrenDepartmens[i].Id;
                    queue.Enqueue(childrenNodes[i]);
                }
                FillTreeNode(parentNode, childrenNodes);
            }
        }

        private Department[] GetChildrenDepartments(Department parentDepartment)
        {
            var childrenDepartmens = departments
                    .Where(d => d.ParentDepartmentId == parentDepartment.Id)
                    .ToArray();
            return childrenDepartmens;
        }

        private void FillTreeNode(TreeNode node, TreeNode[] childrenNodes)
        {           
            foreach (var child in childrenNodes)
                node.Nodes.Add(child);
        }

        private Department GetRootDepartment()
        {
            var company = departments
                .Where(d => d.ParentDepartmentId == null)
                .FirstOrDefault();
            return company;
        }

        private void PopulateDataGridView(Guid departmentId)
        {
            db = new DataContext(connectionString);
            employees = db.GetTable<Employee>().ToList();
            dgvEmployees.AutoGenerateColumns = false;
            var employeesToShow = new List<Employee>();
            var queue = new Queue<Guid>();
            queue.Enqueue(departmentId);
            while(queue.Count != 0)
            {
                var parentdepartmentId = queue.Dequeue();
                var employeesFromDepartment = employees
                    .Where(e => e.DepartmentId == parentdepartmentId)
                    .ToList();
                employeesToShow.AddRange(employeesFromDepartment);
                var childrenDepartmentsId = departments
                    .Where(d => d.ParentDepartmentId == parentdepartmentId)
                    .Select(d => d.Id);
                foreach (var childId in childrenDepartmentsId)
                    queue.Enqueue(childId);
            }

            dgvEmployees.DataSource = employeesToShow;
        }

        private void DepartmentsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedDepartmentId = (Guid)DepartmentsTreeView.SelectedNode.Tag;
            PopulateDataGridView(selectedDepartmentId);
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {            
            employeeForm.Department = DepartmentsTreeView.SelectedNode.Name;
            employeeForm.State = State.New;
            employeeForm.ShowDialog();
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow.Index != -1)
            {
                employeeForm.State = State.Update;
                employeeForm.EmployeeId = Convert.ToDecimal(dgvEmployees.CurrentRow.Cells["Id"].Value);              
                employeeForm.ShowDialog();
            }
        }
    }
}
