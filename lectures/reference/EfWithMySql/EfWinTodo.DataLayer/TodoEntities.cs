using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstTodo
{
    public class TodoEntities : DbContext
    {
        public TodoEntities() : base("TodoEntities")
        {
            Database.SetInitializer(new TodoEntitiesInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().Ignore(x => x.IsDone);
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
