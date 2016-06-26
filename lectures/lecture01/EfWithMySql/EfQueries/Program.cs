using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SchoolEntities();
            var isAnyStudent = db.student.Any();
            Console.WriteLine(isAnyStudent);
        }
    }
}
