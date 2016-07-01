using SweetStuff.Dump;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    static class StudentExtensions
    {
        public static List<Student> Filter(this List<Student> students, Func<Student, bool> condition)
        {
            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (condition(student))
                {
                    filteredStudents.Add(student);
                }
            }

            return filteredStudents;
        }
    }

    class StudentNameFilter
    {
        private string _name;

        public StudentNameFilter(string name)
        {
            _name = name;
        }

        public bool IsNameMatch(Student student)
        {
            bool isMatch = student.StudentName == _name;
            return isMatch;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UseLoopToFindElements();

            UseFunctionToFindStudentByName();
            UseFunctionToFindTeenageStudents();

            UseDelegateToFindStudentByName();
            UseDelegateToFindTeenageStudents();

            UseLambdaToFindStudentByName();
            UseLambdaToFindTeenageStudents();

            UseExtensionToFindStudentByName();

            UseMethodSyntaxToFindTeenageStudents();
            UseLinqQuerySyntaxToFindTeenageStudents();

            SaveFunctionInVariable();
        }

        private static void SaveFunctionInVariable()
        {
            Func<int, int, int> binaryFunc;
            int a = 1;
            int b = 2;

            int res = Add(a, b);
            Console.WriteLine("Add: {0}", res);

            binaryFunc = Add;
            res = binaryFunc(a, b);
            Console.WriteLine("Add with delegate: {0}", res);

            binaryFunc = Substract;
            res = binaryFunc(a, b);
            Console.WriteLine("Substract with delegate: {0}", res);

            binaryFunc = (x, y) => x + y;
            res = binaryFunc(a, b);
            Console.WriteLine("Add with lambda: {0}", res);
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Substract(int a, int b)
        {
            return a - b;
        }

        private static void UseMethodSyntaxToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseMethodSyntaxToFindTeenageStudents)}");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = students.Where(student => student.Age > 12 && student.Age < 20).ToList();

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseExtensionToFindStudentByName()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseExtensionToFindStudentByName)}");


            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = students.Filter(student => student.StudentName == "Rob");

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseLambdaToFindStudentByName()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseLambdaToFindStudentByName)}");


            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = StudentExtensions.Filter(students,
                student => student.StudentName == "Rob");

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseLambdaToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseLambdaToFindTeenageStudents)}");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = StudentExtensions.Filter(students, 
                student => student.Age > 12 && student.Age < 20);

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseDelegateToFindStudentByName()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseDelegateToFindStudentByName)}");

            List<Student> students = GetSomeStudents();

            var filter = new StudentNameFilter("Rob");
            List<Student> filteredStudents = StudentExtensions.Filter(students, filter.IsNameMatch);

            Console.WriteLine(filteredStudents.DumpJson());

        }

        private static void UseDelegateToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseDelegateToFindTeenageStudents)}");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = StudentExtensions.Filter(students, IsTeenager);

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseFunctionToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseFunctionToFindTeenageStudents)}");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (IsTeenager(student))
                {
                    filteredStudents.Add(student);
                }
            }

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static bool IsTeenager(Student student)
        {
            bool isTeenager = student.Age > 12 && student.Age < 20;
            return isTeenager;
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
            Console.WriteLine($"******* {nameof(Program.UseFunctionToFindStudentByName)}");

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
            Console.WriteLine($"******* {nameof(Program.UseLoopToFindElements)}");

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

        private static void UseLinqQuerySyntaxToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.UseLinqQuerySyntaxToFindTeenageStudents)}");

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
