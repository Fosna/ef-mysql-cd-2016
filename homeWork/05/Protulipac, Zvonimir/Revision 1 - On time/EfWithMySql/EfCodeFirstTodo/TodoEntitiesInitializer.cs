using System;
using System.Data.Entity;

namespace EfCodeFirstTodo
{
    // Database will be dropped and created again on every database schema change.
    // Use only for development!!!
    public class TodoEntitiesInitializer : DropCreateDatabaseIfModelChanges<TodoEntities>
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
                Description = "Have fun with yoyo",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = DateTime.Now.AddDays(-1),
            });

            context.TodoItems.Add(new TodoItem
            {
                Description = "Make some honey",
                TimeCreated = DateTime.Now.AddDays(-5),
                TimeSetToDone = DateTime.Now.AddDays(-1),
                TimeDeactivated = DateTime.Now.AddHours(-3),
            });

            // ... Add some more

            base.Seed(context);
        }
    }
}