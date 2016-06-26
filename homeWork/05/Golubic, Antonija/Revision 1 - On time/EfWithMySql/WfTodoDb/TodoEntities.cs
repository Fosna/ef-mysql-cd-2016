using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfTodoDb
{
    public class TodoEntities : DbContext
    {
        public TodoEntities() : base("TodoEntities")
        {
            Database.SetInitializer(new TodoEntitiesInitializer());
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
