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
            List<todoitem> todoItemList = db.todoitem.ToList();

            // Write each todo item to console.
            foreach (var todoItem in todoItemList)
            {
                Console.WriteLine($"Id: {todoItem.Id}");
                Console.WriteLine($"Description: {todoItem.Description}");
                Console.WriteLine($"Created: {todoItem.TimeCreated}");
                var isDone = false;
                if (todoItem.TimeSetToDone.HasValue)
                {
                    isDone = true;
                }
                Console.WriteLine($"Done?: {isDone}");
                Console.WriteLine();
            }
        }
    }
}
