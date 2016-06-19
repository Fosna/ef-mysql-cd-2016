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
                if (todoItem.TimeDeactivated.HasValue == false)
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

        /*    internal void SetDone()
            {
              --  int id;
             --   if (TryReadId(out id))
              --  {
                   var setMeToDone = -- db.todoitem.SingleOrDefault(x => x.Id == id);
                --    if (setMeToDone != null)
                    {
                        setMeToDone.TimeSetToDone = DateTime.Now;
                        this.db.SaveChanges();

                        Console.WriteLine("Todo items set to done.");
                    }
                    --else
                    {
                        Console.WriteLine("Todo item not found. Please enter valid todo item id.");
                    }
                }
            }
    */

        internal void SetDone()
        {
            todoitem setMeToDone;
            if (TryGetTodoItem(out setMeToDone))
            {
                setMeToDone.TimeSetToDone = DateTime.Now;
                this.db.SaveChanges();
                Console.WriteLine("Todo items set to done.");
            }
        }

        internal void SetUndone()
        {
            todoitem setMeToUndone;
            if (TryGetTodoItem(out setMeToUndone))
            {
                setMeToUndone.TimeSetToDone = null;
                this.db.SaveChanges();
                Console.WriteLine("Todo items set to undone.");
            }
        }


        /*OLD REMOVE

          internal void Remove()
          {
               todoitem deleteMe;
               if (TryGetTodoItem(out deleteMe))
               {
                   this.db.todoitem.Remove(deleteMe);
                   this.db.SaveChanges();
                   Console.WriteLine("Todo item has been removed.");
               }
          }
          */

        internal void Remove()
        {
            todoitem deleteMe;
            if (TryGetTodoItem(out deleteMe))
            {
                deleteMe.TimeDeactivated = DateTime.Now;
                this.db.SaveChanges();
                Console.WriteLine("Todo item has been removed.");
            }
        }


        internal void RemoveAll()
        {
            // Code review: Only active items should be deactivated. Otherwise time deactivated is corrupt for items that are already deactivated.
            var todoItems = this.db.todoitem.Where(x => x.TimeDeactivated == null).ToList();
            foreach (var deleteMe in todoItems)
            {
                if (deleteMe.TimeDeactivated.HasValue == false)
                {
                    deleteMe.TimeDeactivated = DateTime.Now;
                }
            }
            this.db.SaveChanges();
            Console.WriteLine("All Todo items have been removed.");
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

        private bool TryGetTodoItem(out todoitem todo)
        {
            int id;
            if (TryReadId(out id))
            {
                todo = db.todoitem.SingleOrDefault(x => x.Id == id);

                if (todo != null)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Todo item not found. Please enter valid todo item id.");
                    return false;
                }
            }
            else
            {   
                Console.WriteLine("Todo item not found. Please enter valid todo item id.");
                todo = null;
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
    }
}