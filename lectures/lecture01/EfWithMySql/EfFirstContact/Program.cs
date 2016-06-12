using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFirstContact
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create database context. Context is generated from ADO.NET Entity Data Model database first wizard. 
            var db = new todoEntities();
            // db.todoitem is table representation of TodoItem table in database.
            // Any is extension method that checks if there are any rows in database.
            var todoItemsExist = db.todoitem.Any();

            Console.WriteLine(todoItemsExist);
        }
    }
}
