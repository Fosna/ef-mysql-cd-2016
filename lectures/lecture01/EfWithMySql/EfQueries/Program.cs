using SweetStuff;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSchoolDbAccess();

            Console.WriteLine("*********************** ex 1");
            using (var db = new SchoolEntities())
            {
                db.Database.Log = logRecord => Console.WriteLine(logRecord);

                List<standard> standardList = db.standard.ToList();

                //List<string> standardStringList = standardList.Select(x => x.ToString()).ToList();
                //string standardListText = string.Join(Environment.NewLine, standardStringList);
                //Console.WriteLine(standardListText);

                ConsoleWriteList(standardList);
            }


            Console.WriteLine("*********************** ex 2");
            using (var db = new SchoolEntities())
            {
                db.Database.Log = logRecord => Console.WriteLine(logRecord);

                standard firstStandard = db.standard.Single(s => s.StandardId == 1);
                Console.WriteLine(firstStandard);

                List<teacher> firstStandardTeacherList = db.teacher.Where(t => t.StandardId == 1).ToList();
                ConsoleWriteList(firstStandardTeacherList);

                ConsoleWriteList(firstStandard.teacher.ToList());
            }

            Console.WriteLine("******************* ex 3");

            using (var db = new SchoolEntities())
            {
                db.Database.Log = logRecord => Console.WriteLine(logRecord);

                standard firstStandard = db.standard.
                    Include(s => s.teacher).
                    Single(s => s.StandardId == 1);

                Console.WriteLine(firstStandard);
                ConsoleWriteList(firstStandard.teacher.ToList());
            }

            Console.WriteLine("******************* ex 4");
            using (var db = new SchoolEntities())
            {
                db.Database.Log = logRecord => Console.WriteLine(logRecord);

                var q =
                    from s in db.standard
                    join t in db.teacher
                        on s.StandardId equals t.StandardId
                    where s.StandardId == 1
                    select new { s, t };
                var qList = q.ToList();

                ConsoleWriteList(qList.Select(x => x.s).Distinct().ToList());
                ConsoleWriteList(qList.Select(x => x.t).ToList());
            }
        }

        private static void ConsoleWriteList<T>(List<T> itemList)
        {
            Console.WriteLine(string.Join(Environment.NewLine, itemList.Select(x => x.ToString())));
        }

        private static void TestSchoolDbAccess()
        {
            var db = new SchoolEntities();
            var isAnyStudent = db.student.Any();
            Console.WriteLine(isAnyStudent);
        }
    }
}
