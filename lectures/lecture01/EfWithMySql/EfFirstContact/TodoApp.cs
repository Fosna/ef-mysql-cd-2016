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
            var todoItemList = this.db.todoitem.ToList();

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

        internal void SetDone()
        {
            Console.Write("Id> ");
            var idText = Console.ReadLine().Trim();

            int id;
            if (int.TryParse(idText, out id))
            {
                Console.WriteLine("Debug: {0}", id);
            }
            else
            {
                Console.WriteLine("Invalid input. Please write todo item id.");
            }
        }

        internal void Add()
        {
            Console.Write("Description > ");
            var description = Console.ReadLine().Trim();

            var addMe = new todoitem();
            addMe.Description = description;
            addMe.TimeCreated = DateTime.Now;

            this.db.todoitem.Add(addMe);
            this.db.SaveChanges();
        }
    }
}