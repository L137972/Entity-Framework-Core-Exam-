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
    public class StudentLectures
    {
        public string LectureId { get; set; }
        public string LectureName { get; set; }
        public Lecture Lecture { get; set; }

        public string StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }

        public Student Student { get; set; }
        public StudentLectures()
        {

        }

        public void AddStudentToLecture(string lectureId, string studentId)
        {
            using var dbContext = new DepartmentContext();
            Lecture = dbContext.Lectures.Find(lectureId);
            Student = dbContext.Students.Find(studentId);
            StudentLectures studentLectures = new StudentLectures
            {
                LectureId = lectureId,
                Lecture = Lecture,
                LectureName = Lecture.Name,
                StudentId = studentId,
                Student = Student,
                StudentFirstName = Student.FirstName,
                StudentLastName = Student.LastName
            };

            dbContext.Add(studentLectures);

            dbContext.SaveChanges();
        }
    }
}
