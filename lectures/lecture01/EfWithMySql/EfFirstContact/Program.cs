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
            var db = new todoEntities();
            var todoItemsExist = db.todoitem.Any();
            Console.WriteLine(todoItemsExist);
        }
    }
}
