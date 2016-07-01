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
        private static object teenagerStudent;

        static void Main(string[] args)
        {
            LinqQuerySyntax();
        }

        private static void LinqQuerySyntax()
        {
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
