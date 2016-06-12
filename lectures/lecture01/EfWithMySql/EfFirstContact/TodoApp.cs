using System;
using System.Linq;

namespace EfFirstContact
{
    internal class TodoApp
    {
        private todoEntities db;

        public TodoApp()
        {
            this.db = new todoEntities();
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
    }
}