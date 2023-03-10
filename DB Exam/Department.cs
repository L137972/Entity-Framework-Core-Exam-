using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Exam
{
    public class Department 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<DepartmentLectures> DepartmentLectures { get; set; }
        public List<Student> Students { get; set; }
        public Department(string id, string name)
        {
            Id = id;
            Name = name;
            DepartmentLectures = new List<DepartmentLectures>();
            Students = new List<Student>();
        }
        public Department()
        {
            DepartmentLectures = new List<DepartmentLectures>();
            Students = new List<Student>();
        }

        public void AddDepartment (string id, string name)
        {
            using var dbContext = new DepartmentContext();

            var department = new Department(Id = id, Name = name);
            dbContext.Departments.Add(department);

            dbContext.SaveChanges();
        }



    }
}
