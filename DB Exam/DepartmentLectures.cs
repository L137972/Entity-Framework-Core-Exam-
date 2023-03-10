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
    public class DepartmentLectures
    {
        public string LectureId { get; set; }
        public string LectureName { get; set; }
        public Lecture Lecture { get; set; }

        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Department Department { get; set; }
        public DepartmentLectures()
        {

        }

        public void AddLecturesToDepartments(string departmentId, string lectureId)
        {
            using var dbContext = new DepartmentContext();
            Department = dbContext.Departments.Find(departmentId);
            Lecture = dbContext.Lectures.Find(lectureId);
            DepartmentLectures departmentLectures = new DepartmentLectures
            {
                LectureId = lectureId,
                Lecture = Lecture,
                LectureName = Lecture.Name,
                DepartmentId = departmentId,
                Department = Department,
                DepartmentName = Department.Name
            };

            dbContext.Add(departmentLectures);

            dbContext.SaveChanges();
        }
    }
}
