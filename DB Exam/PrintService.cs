using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Exam
{
    public class PrintService
    {
        public void PrintDepartmentStudents()
        {
            using var dbContext = new DepartmentContext();
            var departmentStudentList = dbContext.Students
                                                  .ToList();

            foreach (var departmentStudent in departmentStudentList)
            {
                Console.Write(departmentStudent.Id + "\t");
                Console.Write(departmentStudent.FirstName + "\t");
                Console.Write(departmentStudent.LastName + "\t");
                Console.Write(departmentStudent.DepartmentId + "\t");
                Console.Write(departmentStudent.DepartmentName + "\t");
                Console.WriteLine();
            }
        }

        public void PrintDepartmentLectures()
        {
            using var dbContext = new DepartmentContext();
            var departmentLectureList = dbContext.DepartmentLectures
                                                  .ToList();

            foreach (var departmentLecture in departmentLectureList)
            {
                Console.Write(departmentLecture.DepartmentId + "\t");
                Console.Write(departmentLecture.DepartmentName + "\t");
                Console.Write(departmentLecture.LectureId + "\t");
                Console.Write(departmentLecture.LectureName + "\t");
                Console.WriteLine();
            }
        }

        public void PrintStudentLectures()
        {
            using var dbContext = new DepartmentContext();
            var studentLectureList = dbContext.StudentLectures
                                                  .ToList();

            foreach (var studentLectures in studentLectureList)
            {
                Console.Write(studentLectures.LectureId + "\t");
                Console.Write(studentLectures.LectureName + "\t");
                Console.Write(studentLectures.StudentId + "\t");
                Console.Write(studentLectures.StudentFirstName + "\t");
                Console.Write(studentLectures.StudentLastName + "\t");
                Console.WriteLine();
            }
        }
    }
}
