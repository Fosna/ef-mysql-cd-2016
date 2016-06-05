using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFirstContact
{
    class TodoApp
    {
        private TodoEntities db;

        public TodoApp()
        {
            this.db = new TodoEntities();
        }

        public void List()
        {
            var todoItemList = db.todoitem.ToList();

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

        public void AddTodoItem()
        {
            var todoInsert = new todoitem();

            Console.Write("Description: > ");
            todoInsert.Description = Console.ReadLine().Trim();

            todoInsert.TimeCreated = DateTime.Now;

            this.db.todoitem.Add(todoInsert);
            this.db.SaveChanges();

            Console.WriteLine("New todo item saved.");
        }

        public void SetDone()
        {
            Console.Write("Enter todo id. > ");
            var rawId = Console.ReadLine();
            int doneId;
            if (int.TryParse(rawId, out doneId))
            {

            }
            else
            {
                Console.WriteLine("Entered value is not a number. Consider entering todo item id number.");
            }
        }
    }
}
