using System;
using System.Data.Entity;

namespace EfCodeFirstTodo
{
    // Database will be dropped and created again on every database schema change.
    // Use only for development!!!
    public class TodoEntitiesInitializer : DropCreateDatabaseAlways<TodoEntities>
    {
        protected override void Seed(TodoEntities context)
        {
            context.TodoItems.Add(new TodoItem
            {
                Description = "Buy milk",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
            });

            // ... Add some more

            base.Seed(context);
        }
    }
}