using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Exam
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<StudentLectures> StudentLectures { get; set; }

        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Department Department { get; set; }

        public Student()
        {
            StudentLectures = new List<StudentLectures>();
        }

        public void AddStudent(string id, string firstName, string lastName, string departmentId)
        {
            using var dbContext = new DepartmentContext();

            var department = dbContext.Departments.Find(departmentId);
            dbContext.Attach(department);

            Student student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                DepartmentId = DepartmentId,
                DepartmentName = department.Name
            };
            department.Students.Add(student);

            dbContext.SaveChanges();
        }

        public void ChangeStudentDepartment(string studentId, string departmentId, string departmentName)
        {
            using var dbContext = new DepartmentContext();

            var student = dbContext.Students.Find(studentId);
            student.DepartmentId = departmentId;
            student.DepartmentName = departmentName;
            dbContext.SaveChanges();
        }


    }
}
