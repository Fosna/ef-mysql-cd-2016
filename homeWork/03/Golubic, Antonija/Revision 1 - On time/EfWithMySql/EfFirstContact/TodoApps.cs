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

        public void RemoveAll()
        {
            var all = this.db.todoitem.ToList();

            foreach (var todoItem in all)
            {
                todoItem.TimeDeactivated = DateTime.Now;
            }
        }

        public void List()
        {
            var todoItemList = this.db.todoitem.Where(x => x.TimeDeactivated == null).ToList();

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
            int id;
            if (TryReadId(out id))
            {
                var setMeToDone = db.todoitem.SingleOrDefault(x => x.Id == id);
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

        internal void Remove()
        {
            int id;
            if (TryReadId(out id))
            {
                var deleteMe = db.todoitem.SingleOrDefault(x => x.Id == id);
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

        internal void Add()
        {
            Console.Write("Description>");
            var description = Console.ReadLine().Trim();

            var addMe = new todoitem();
            addMe.Description = description;
            addMe.TimeCreated = DateTime.Now;

            this.db.todoitem.Add(addMe);
            this.db.SaveChanges();

            Console.WriteLine("Todo item has been added.");
        }

        internal void Undone()
        {
            int id;
            if (TryReadId(out id))
            {
                var setMeToUndone = db.todoitem.SingleOrDefault(x => x.Id == id);
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

        private bool TryGetTodoItem(var tmp)
        {
            int id;
            if (TryReadId(out id))
            {
                tmp = db.todoitem.SingleOrDefault(x => x.Id == id);

                if (tmp != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}