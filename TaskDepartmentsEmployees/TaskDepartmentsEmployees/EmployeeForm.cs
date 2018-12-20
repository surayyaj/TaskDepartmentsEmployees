using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Windows.Forms;
using TaskDepartmentsEmployees.Models;
using System.ComponentModel;
using System.Drawing;

namespace TaskDepartmentsEmployees
{
    public enum State
    {
        New,
        Update
    }
    public partial class EmployeeForm : Form
    {
        private string connectionString;
        private DataContext db;
        private List<Department> departments;
        private List<Employee> employees;
        public Action<Guid> action;
        public State State { get; set; }
        public string Department { get; set; }
        public decimal EmployeeId { get; set; }
        public bool IsValid { get; set; }
        public EmployeeForm()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            db = new DataContext(connectionString);
            departments = db.GetTable<Department>().ToList();
            employees = db.GetTable<Employee>().ToList();
            IsValid = true;
            InitializeComponent();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            FillDropDown();
            if (State == State.New)
                AddEmployee();
            else
                UpdateEmployee();

        }

        private void FillDropDown()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataContext db = new DataContext(connectionString);
            Table<Department> departments = db.GetTable<Department>();
            dropDownDepartments.DisplayMember = "DepartmentName";
            dropDownDepartments.ValueMember = "Id";
            dropDownDepartments.SelectedItem = Department;
            dropDownDepartments.DataSource = departments;
        }

        private void AddEmployee()
        {
            State = State.New;
            lblNewUpdate.Text = "Новый сотрудник";
            if (IsValid)
                txtFirstName.Text = txtLastName.Text = txtPatronymic.Text
                = txtDocSeries.Text = txtDocNumber.Text = txtPosition.Text = "";
        }



        private void UpdateEmployee()
        {
            lblNewUpdate.Text = "Редактировать сотрудника";
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataContext db = new DataContext(connectionString);
            Table<Employee> employees = db.GetTable<Employee>();
            var employee = employees.Where(e => e.Id == EmployeeId).FirstOrDefault();
            if (IsValid)
                MapFieldsToEmployee(employee);
            Department = employee.Department;
            dropDownDepartments.Text = Department;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateFields();
            if (!IsValid)
            {
                if (State == State.Update) UpdateEmployee();
                else AddEmployee();
                return;
            }
            else
                Clear();
            var employee = new Employee();
            MapEmployeeToFields(employee);
            if (State == State.New)
                db.GetTable<Employee>().InsertOnSubmit(employee);
            else
            {
                employee.Id = EmployeeId;
                var employeeFcromDB = db.GetTable<Employee>()
                    .Where(d => d.Id == EmployeeId)
                    .FirstOrDefault();
                MapEmployeeToEmployee(employeeFcromDB, employee);
            }
            db.SubmitChanges();
            employees = db.GetTable<Employee>().ToList();
            dropDownDepartments.Text = employee.Department;
            action(employee.DepartmentId);
            string successMessage = (State == State.New) ? "Сотрудник добавлен" : "Сотрудник обновлен";
            Close();
            MessageBox.Show(successMessage);
        }

        private void MapFieldsToEmployee(Employee employee)
        {
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtPatronymic.Text = employee.Patronymic;
            dtpDateOfBirth.Value = employee.DateOfBirth;
            txtDocSeries.Text = employee.DocSeries;
            txtDocNumber.Text = employee.DocNumber;
            txtPosition.Text = employee.Position;
            dropDownDepartments.SelectedItem = employee.DepartmentId;
        }

        private void MapEmployeeToFields(Employee employee)
        {
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Patronymic = txtPatronymic.Text;
            employee.DateOfBirth = dtpDateOfBirth.Value;
            employee.DocSeries = txtDocSeries.Text;
            employee.DocNumber = txtDocNumber.Text;
            employee.Position = txtPosition.Text;
            employee.DepartmentId = (Guid)dropDownDepartments.SelectedValue;
        }

        private void MapEmployeeToEmployee(Employee employee1, Employee employee2)
        {
            employee1.FirstName = employee2.FirstName;
            employee1.LastName = employee2.LastName;
            employee1.Patronymic = employee2.Patronymic;
            employee1.DateOfBirth = employee2.DateOfBirth;
            employee1.DocSeries = employee2.DocSeries;
            employee1.DocNumber = employee2.DocNumber;
            employee1.Position = employee2.Position;
            employee1.DepartmentId = employee2.DepartmentId;
        }

        private void ValidateFields()
        {
            IsValid = true;

            if (txtFirstName.Text == "")
            {
                IsValid = false;
                txtFirstName.BackColor = Color.Pink;
                lblFirstNameRequired.Text = "Укажите имя!";
            }

            if (txtFirstName.Text.Length >= 50)
            {
                IsValid = false;
                txtFirstName.BackColor = Color.Pink;
                lblFirstNameError.Text = "Слишком длинное имя!";
            }

            if (txtLastName.Text == "")
            {
                IsValid = false;
                txtLastName.BackColor = Color.Pink;
                lblLastNameRequired.Text = "Укажите фамилию!";
            }

            if (txtLastName.Text.Length >= 50)
            {
                IsValid = false;
                txtLastName.BackColor = Color.Pink;
                lblLastNameError.Text = "Слишком длинная фамилия!";
            }


            if (txtPatronymic.Text != "" && txtPatronymic.Text.Length >= 50)
            {
                IsValid = false;
                txtPatronymic.BackColor = Color.Pink;
                lblPatronymicError.Text = "Слишком длинное отчество!";
            }

            if (txtDocSeries.Text != "" && txtDocSeries.Text.Length != 4)
            {
                IsValid = false;
                txtDocSeries.BackColor = Color.Pink;
                lblDocSeriesError.Text = "Серия документа должна состоять из 4 символов!";
            }

            if (txtDocNumber.Text != "" && txtDocNumber.Text.Length != 6)
            {
                IsValid = false;
                txtDocNumber.BackColor = Color.Pink;
                lblDocNumberError.Text = "Номер документа должен состоять из 6 символов!";
            }

            if (txtPosition.Text == "")
            {
                IsValid = false;
                txtPosition.BackColor = Color.Pink;
                lblPositionRequired.Text = "Укажите должность!";
            }

            if (txtPosition.Text.Length >= 50)
            {
                IsValid = false;
                txtPosition.BackColor = Color.Pink;
                lblPositionError.Text = "Слишком длинное название должности!";
            }

            var dateOfBirth = dtpDateOfBirth.Value;
            var age = Employee.CalculateAge(dateOfBirth);
            if (age < 16)
            {
                IsValid = false;
                lblDateOfBirthError.BackColor = Color.Pink;
                lblDateOfBirthError.Text = "Сотрудник слишком молод";
            }
            if (age > 98)
            {
                IsValid = false;
                lblDateOfBirthError.BackColor = Color.Pink;
                lblDateOfBirthError.Text = "Сотрудник слишком стар";
            }
        }

        private void Clear()
        {
            lblFirstNameError.Text = lblLastNameError.Text = lblPatronymicError.Text
                = lblDocSeriesError.Text = lblDocNumberError.Text = lblPositionError.Text
                = lblDateOfBirthError.Text = lblFirstNameRequired.Text
                = lblLastNameRequired.Text = lblPositionRequired.Text = "";

            txtFirstName.BackColor = txtLastName.BackColor = txtPatronymic.BackColor
                = txtDocSeries.BackColor = txtDocNumber.BackColor = txtPosition.BackColor 
                = lblDateOfBirthError.BackColor = Color.White;
        }

        private void EmployeeForm_FormClosed(object sender, FormClosingEventArgs e)
        {
            IsValid = true;
            Clear();
        }

        private void ClearField(TextBox textbox, params Label[] labels)
        {
            textbox.BackColor = Color.White;
            foreach (var label in labels)
                label.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ClearField(txtFirstName, lblFirstNameError, lblFirstNameRequired);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ClearField(txtLastName, lblLastNameError, lblLastNameRequired);
        }

        private void txtPatronymic_TextChanged(object sender, EventArgs e)
        {
            ClearField(txtPatronymic, lblPatronymicError);
        }

        private void txtDocSeries_TextChanged(object sender, EventArgs e)
        {
            ClearField(txtDocSeries, lblDocSeriesError);
        }

        private void txtDocNumber_TextChanged(object sender, EventArgs e)
        {
            ClearField(txtDocNumber, lblDocNumberError);
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            ClearField(txtPosition, lblPositionError, lblPositionRequired);
        }

        private void dtpDateOfBirth_DropDown(object sender, EventArgs e)
        {
            lblDateOfBirthError.BackColor = Color.White;
            lblDateOfBirthError.Text = "";
        }
    }
}
