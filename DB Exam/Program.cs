using DB_Exam;
using Microsoft.EntityFrameworkCore;
using System.Linq;

Department department = new Department();
department.AddDepartment("D1", "Arts");
department.AddDepartment("D2", "Political Science and Diplomacy");
department.AddDepartment("D3", "Economics and Management");
department.AddDepartment("D4", "Informatics");
department.AddDepartment("D5", "Social Sciences");

Lecture lecture = new Lecture();
lecture.AddLecture("L1", "Composition");
lecture.AddLecture("L2", "Mathematics");
lecture.AddLecture("L3", "Political Systems");
lecture.AddLecture("L4", "Microeconomics");
lecture.AddLecture("L5", "Object Oriented Programming");
lecture.AddLecture("L6", "Public Relations");
lecture.AddLecture("L7", "Art History");

DepartmentLectures departmentLectures = new DepartmentLectures();
departmentLectures.AddLecturesToDepartments("D1", "L1");
departmentLectures.AddLecturesToDepartments("D1", "L7");

departmentLectures.AddLecturesToDepartments("D2", "L3");
departmentLectures.AddLecturesToDepartments("D2", "L2");
departmentLectures.AddLecturesToDepartments("D2", "L7");

departmentLectures.AddLecturesToDepartments("D3", "L2");
departmentLectures.AddLecturesToDepartments("D3", "L4");
departmentLectures.AddLecturesToDepartments("D3", "L7");

departmentLectures.AddLecturesToDepartments("D4", "L2");
departmentLectures.AddLecturesToDepartments("D4", "L5");
departmentLectures.AddLecturesToDepartments("D4", "L7");

departmentLectures.AddLecturesToDepartments("D5", "L6");
departmentLectures.AddLecturesToDepartments("D5", "L7");

Student student = new Student();
student.AddStudent("IT2300311", "Vardenis", "Pavardenis", "D4");
student.AddStudent("A2300122", "Vardenė", "Pavardenė", "D1");
student.AddStudent("PSD2300230", "Jonas", "Jonaitis", "D2");
student.AddStudent("EM2300345", "Petras", "Petraitis", "D3");
student.AddStudent("SS2300589", "Marytė", "Kaziliūnaitė", "D5");

StudentLectures studentLectures = new StudentLectures();
studentLectures.AddStudentToLecture("L7", "IT2300311");
studentLectures.AddStudentToLecture("L2", "IT2300311");
studentLectures.AddStudentToLecture("L4", "IT2300311");

studentLectures.AddStudentToLecture("L7", "A2300122");
studentLectures.AddStudentToLecture("L1", "A2300122");

studentLectures.AddStudentToLecture("L7", "PSD2300230");
studentLectures.AddStudentToLecture("L2", "PSD2300230");
studentLectures.AddStudentToLecture("L3", "PSD2300230");

studentLectures.AddStudentToLecture("L7", "EM2300345");
studentLectures.AddStudentToLecture("L2", "EM2300345");
studentLectures.AddStudentToLecture("L4", "EM2300345");

studentLectures.AddStudentToLecture("L7", "SS2300589");
studentLectures.AddStudentToLecture("L6", "SS2300589");

student.ChangeStudentDepartment("A2300122", "D5", "Social Sciences");

PrintService print = new PrintService();
Console.WriteLine("Print values? (y/n)");
string userInput = Console.ReadLine();
do
{
    Console.WriteLine("Print: ");
    Console.WriteLine("1 - List of students ; 2 - List of lectures by department ; 3 - List of lectures by student");
    int userChoice = Convert.ToInt32(Console.ReadLine());
    switch (userChoice)
    {
        case 1:
            print.PrintDepartmentStudents();
            Console.WriteLine("Print again? (y/n)");
            userInput = Console.ReadLine();
            break;
        case 2:
            print.PrintDepartmentLectures();
            Console.WriteLine("Print again? (y/n)");
            userInput = Console.ReadLine();
            break;
       case 3:
            print.PrintStudentLectures();
            Console.WriteLine("Print again? (y/n)");
            userInput = Console.ReadLine();
            break;
    }
}
while (userInput == "y");

