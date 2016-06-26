using System;
using System.Linq;

namespace EfCodeFirstTodo
{

    public class TodoApp
    {
        private TodoEntities db;
        public TodoApp()
        {
            this.db = new TodoEntities();

            db.Database.Log = logEntry => Console.WriteLine();
        }

        public void RemoveAll()
        {
            var all = this.db.TodoItems.ToList();

            foreach (var todoItem in all)
            {
                todoItem.TimeDeactivated = DateTime.Now;
            }
            Console.WriteLine("Todo items removed.");
            this.db.SaveChanges();
        }

        public void List()
        {
            var todoList = this.db.TodoItems.Where(x => x.TimeDeactivated == null).ToList();

            foreach (var todoItem in todoList)
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

        public void SetDone()
        {
            int id;
            if (TryReadId(out id))
            {
                var setMeToDone = db.TodoItems.SingleOrDefault(x => x.Id == id);
                if (setMeToDone != null)
                {
                    setMeToDone.TimeSetToDone = DateTime.Now;
                    this.db.SaveChanges();

                    Console.WriteLine("Todo items set to done.");
                }
                else
                {
                    Console.WriteLine("Todo item not found. Please enter valid todo item id.");
                }
            }
        }

        public void Remove()
        {
            int id;
            if (TryReadId(out id))
            {
                var deleteMe = db.TodoItems.SingleOrDefault(x => x.Id == id);
                if (deleteMe != null)
                {
                    deleteMe.TimeDeactivated = DateTime.Now;
                    this.db.SaveChanges();

                    Console.WriteLine("Todo item removed.");
                }
                else
                {
                    Console.WriteLine("Todo item not found. Please enter valid todo item id.");
                }
            }
        }

        private bool TryReadId(out int id)
        {
            Console.Write("Id>");
            var idText = Console.ReadLine().Trim();

            if (int.TryParse(idText, out id))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter todo item id.");
                return false;
            }
        }

        public void Add()
        {
            try
            {
                Console.Write("Description>");
                var description = Console.ReadLine().Trim();

                var addMe = new TodoItem();
                addMe.Description = description;
                addMe.TimeCreated = DateTime.Now;

                this.db.TodoItems.Add(addMe);
                this.db.SaveChanges();

                Console.WriteLine("Todo item has been added.");
            }
            catch (Exception x)
            {
                throw;
            }
        }

        public void Undone()
        {
            int id;
            if (TryReadId(out id))
            {
                var setMeToUndone = db.TodoItems.SingleOrDefault(x => x.Id == id);
                if (setMeToUndone != null)
                {
                    setMeToUndone.TimeSetToDone = null;
                    this.db.SaveChanges();

                    Console.WriteLine("Todo items undone.");
                }
                else
                {
                    Console.WriteLine("Todo item not found. Please enter valid todo item id.");
                }
            }
        }

    }
}