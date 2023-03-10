using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Exam
{
    public class Lecture
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<DepartmentLectures> DepartmentLectures { get; set; }
        public List<StudentLectures> StudentLectures { get; set; }
        public List<Student> Students { get; set; }

        public Lecture(string id, string name)
        {
            Id = id;
            Name = name;
            Students = new List<Student>();
            DepartmentLectures = new List<DepartmentLectures>();
            StudentLectures = new List<StudentLectures>();
        }
        public Lecture()
        {
            Students = new List<Student>();
            DepartmentLectures = new List<DepartmentLectures>();
            StudentLectures = new List<StudentLectures>();
        }

        public void AddLecture(string lectureId, string lectureName)
        {
            using var dbContext = new DepartmentContext();

            var lecture = new Lecture(Id = lectureId, Name = lectureName);
            dbContext.Lectures.Add(lecture);

            dbContext.SaveChanges();
        }

    }
}
