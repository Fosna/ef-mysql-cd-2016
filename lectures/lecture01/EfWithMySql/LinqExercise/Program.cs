using SweetStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    class Program
    {
        static void Main(string[] args)
        {
            //UseLoopToFindElements();

            //UseFunctionToFindStudentByName();
            //UseFunctionToFindTeenageStudents();

            //UseDelegateToFindTeenageStudnets();

            //UseLambdaToFindTeenageStudnets();

            //UseExtensionToFindTeenageStudents();

            //SaveFunctionInVariable();

            //LinqQuerySyntax();

            //UseProjection();

            AggregateFunctions();
        }

        private static void AggregateFunctions()
        {
            var meString = string.Join(", ", GetSomeStudents().Where(x => IsTeenager(x)).Count().DumpJson(),
            GetSomeStudents().Where(x => IsTeenager(x)).Min(x => x.Age).DumpJson(),
            GetSomeStudents().Where(x => IsTeenager(x)).Max(x => x.Age).DumpJson());

            Console.WriteLine(meString);

            var json = GetSomeStudents().
                //Where(x => IsTeenager(x)).
                GroupBy(x => x.Age).
                Select(x => new { Age = x.Key, Count = x.Count() }).
                ToList().
                DumpJson();

            Console.WriteLine(json);

            var aggregateExample =
                from s in GetSomeStudents()
                group s by s.Age into ss
                select new { Age = ss.Key, Count = ss.Count() };
            Console.WriteLine(aggregateExample.DumpJson());
        }

        private static void UseProjection()
        {
            //var json = GetSomeStudents().
            //    Select(s => new { Id = s.StudentID, Age = s.Age }).
            //    ToList().DumpJson();
            //Console.WriteLine(json);

            var json = GetSomeStudents().
                Select(s => new Student
                {
                    StudentID = s.StudentID,
                    Age = s.Age
                }).
                ToList().DumpJson();
            Console.WriteLine(json);
        }

        private static void UseExtensionToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseExtensionToFindTeenageStudents");

            List<Student> students = GetSomeStudents();

            //List<Student> filteredStudents = 
            //    StudentExtensions.Filter(
            //        StudentExtensions.Filter(students, student => student.Age > 12 && student.Age < 20),
            //        student => student.StudentName == "John"
            //    );

            List<Student> filteredStudents = students.Filter(s => s.Age > 12 && s.Age < 20).Filter(s => s.StudentName == "John");

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void SaveFunctionInVariable()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"******* {nameof(Program.SaveFunctionInVariable)}");

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

        private static int Substract(int a, int b)
        {
            return a - b;
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static void UseLambdaToFindTeenageStudnets()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseDelegateToFindTeenageStudnets");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = StudentExtensions.Filter(students, 
                student => student.Age > 12 && student.Age < 20);

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseDelegateToFindTeenageStudnets()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseDelegateToFindTeenageStudnets");

            List<Student> students = GetSomeStudents();

            List<Student> filteredStudents = StudentExtensions.Filter(students, IsTeenager);

            Console.WriteLine(filteredStudents.DumpJson());
        }

        private static void UseFunctionToFindTeenageStudents()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******* UseFunctionFindTeenageStudents");

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
                new Student() { StudentID = 8, StudentName = "John", Age = 21 },
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
            IList<Student> students = GetSomeStudents();

            // LINQ Query Syntax to find out teenager students
            IEnumerable<Student> teenagerStudent =
                from s in students
                where s.Age > 12 && s.Age < 20
                select s;

            Console.WriteLine(teenagerStudent.DumpJson());
        }
    }
}
