using System;
using System.Configuration;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlTypes;

namespace TaskDepartmentsEmployees.Models
{ 
    [Table(Name = "Empoyee")]
    public class Employee
    {
        [Column(Name = "ID", IsPrimaryKey = true, IsDbGenerated = true)]
        public decimal Id { get; set; }

        [Column(CanBeNull = false)]
        public string FirstName { get; set; }

        [Column(Name = "SurName", CanBeNull = false)]
        public string LastName { get; set; }

        [Column]
        public string Patronymic { get; set; }

        [Column]
        public DateTime DateOfBirth { get; set; }

        public int Age { get { return CalculateAge(DateOfBirth); } }

        [Column]
        public string DocSeries { get; set; }

        [Column]
        public string DocNumber { get; set; }

        [Column(CanBeNull = false)]
        public string Position { get; set; }

        [Column(Name = "DepartmentID")]
        public Guid DepartmentId { get; set; }

        public string Department{ get { return GetDepartment().DepartmentName; } set { Department = value; } }

        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.Month < dateOfBirth.Month ||
                (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                age--;
            return age;
        }

        public Department GetDepartment()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataContext db = new DataContext(connectionString);
            Table<Department> departments = db.GetTable<Department>();
            Table<Employee> employees = db.GetTable<Employee>();
            var department = departments
                .Where(d => d.Id == DepartmentId)
                .FirstOrDefault();
            return department;
        }
    }

    



}
