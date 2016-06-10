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
            int doneId;
            if (TryReadTodoId(out doneId))
            {
                todoitem doneTodo;
                if (TryGetTodoById(doneId, out doneTodo))
                {
                    doneTodo.TimeSetToDone = DateTime.Now;
                    db.SaveChanges();
                    Console.WriteLine($"Todo item with id {doneId} set as done.");
                }
            }
        }

        public void Remove()
        {
            int removeId;
            if (TryReadTodoId(out removeId))
            {
                todoitem doneTodo;
                if (TryGetTodoById(removeId, out doneTodo))
                {
                    db.todoitem.Remove(doneTodo);
                    db.SaveChanges();
                    Console.WriteLine($"Todo item with id {removeId} has been removed.");
                }
            }
        }

        private bool TryReadTodoId(out int todoId)
        {
            Console.Write("Enter todo id. > ");
            var rawId = Console.ReadLine();
            if (int.TryParse(rawId, out todoId))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Entered value is not a number. Consider entering todo item id number.");
                todoId = default(int);
                return false;
            }
        }

        private bool TryGetTodoById(int doneId, out todoitem todo)
        {
            todo = db.todoitem.SingleOrDefault(x => x.Id == doneId);
            if (todo != null)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Todo with id {doneId} not found.");
                return false;
            }
        }

    }
}
