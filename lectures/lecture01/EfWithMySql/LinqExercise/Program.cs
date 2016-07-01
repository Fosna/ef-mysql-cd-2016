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
            LinqQuerySyntax();
        }

        private static void UseLoopToFindElements()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseLoopToFindElements");

            Student[] studentArray = 
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris", Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob", Age = 19  },
            };

            Student[] students = new Student[10];

            var filteredStudents = new List<Student>();
            foreach (Student std in studentArray)
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
