using SweetStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            UseLoopToFindElements();
            UseFunctionToFindStudentByName();
            UseFunctionFindTeenageStudents();
            LinqQuerySyntax();
        }

        private static void UseFunctionFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseFunctionFindTeenageStudents");

            throw new NotImplementedException();
        }

        private static bool IsNameMatch(Student student, string studentName)
        {
            bool isMatch = student.StudentName.ToUpper() == studentName.ToUpper();
            return isMatch;
        }

        private static void UseFunctionToFindStudentByName()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseFunctionToFindStudentByName");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (IsNameMatch(student, "Rob"))
                {
                    filteredStudents.Add(student);
                }
            }

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static List<Student> GetSomeStudents()
        {
            var students = new List<Student>
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris", Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob", Age = 19  },
            };
            return students;
        }

        private static void UseLoopToFindElements()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseLoopToFindElements");

            List<Student> students = GetSomeStudents(); 

            var filteredStudents = new List<Student>();
            foreach (Student std in students)
            {
                if (std.Age > 12 && std.Age < 20)
                {
                    filteredStudents.Add(std);
                }
            }

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void LinqQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* LinqQuerySyntax");

            // Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
            };

            // LINQ Query Syntax to find out teenager students
            var teenagerStudent =
                from s in studentList
                where s.Age > 12 && s.Age < 20
                select s;

            Console.WriteLine(teenagerStudent.DumpJson());
        }
    }
}
