using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace TaskDepartmentsEmployees.Models
{
    [Table]
    public class Department
    {      

        [Column(Name = "ID")]
        public Guid Id { get; set; }

        [Column(Name = "Name")]
        public string DepartmentName { get; set; }

        [Column]
        public string Code { get; set; }

        [Column(Name = "ParentDepartmentID")]
        public Guid? ParentDepartmentId { get; set; }

        public string ParentDepartmentName { get { return GetParentDepartmentName(this.ParentDepartmentId); } }     

        private string GetParentDepartmentName(Guid? parentDepartmentId)
        {
            if (Id == null) return "";
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataContext db = new DataContext(connectionString);
            Table<Department> departments = db.GetTable<Department>();
            var name = departments
                .Where(d => d.Id == parentDepartmentId)
                .Select(d => d.DepartmentName)
                .FirstOrDefault();
            return name;
        }
        
        
    }
}
