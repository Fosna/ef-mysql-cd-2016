using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ponavljanje
{
    internal class TodoApp
    {
        private TodoEntities db;

        public TodoApp()
        {
            this.db = new TodoEntities();
        }

        public void List()
        {
            var todoItemList = db.todoitem.Where(x => x.TimeDeactivated.HasValue == false).ToList();

            if (todoItemList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("There is nothing to be done at this time you weak bastard.");
                return;
            }

            foreach (todoitem todoItem in todoItemList)
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
                    this.db.todoitem.Remove(deleteMe);
                    this.db.SaveChanges();

                    Console.WriteLine("Todo item has been removed.");
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

        public todoitem TryGetTodoItem(int itemId)
        {
            todoitem td = new todoitem();
            td = db.todoitem.SingleOrDefault(x => x.Id == itemId);

            if(td==null)
               throw new ArgumentException("Invalid item ID number.");

            return td;
        }

        public void RemoveAllToDoItems()
        {
            var allItems = db.todoitem.ToList();

            foreach (var item in allItems)
            {
                item.TimeDeactivated = DateTime.Now;
                db.todoitem.Attach(item);

                var entry = db.Entry(item);
                entry.State = EntityState.Modified;

                entry.Property(e => e.TimeDeactivated).IsModified = true;
            }

            db.SaveChanges();

            Console.WriteLine("All items have been removed. Bye bye");
        }
    }
}
