using System;
using System.Data.Entity;

namespace EfCodeFirstTodo
{
    public class TodoEntitiesInitializer : DropCreateDatabaseIfModelChanges<TodoEntities>
    //public class TodoEntitiesInitializer : DropCreateDatabaseAlways<TodoEntities>
    {
        protected override void Seed(TodoEntities context)
        {
            context.TodoItems.Add(new TodoItem
            {
                Description = "Buy milk",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
            });

            context.TodoItems.Add(new TodoItem
            {
                Description = "Homework",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
            });

            context.TodoItems.Add(new TodoItem
            {
                Description = "Go home",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
            });

            context.TodoItems.Add(new TodoItem
            {
                Description = "test",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
            });

            base.Seed(context);
        }
    }
}