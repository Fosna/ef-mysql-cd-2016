using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfTodoDb
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public System.DateTime TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeSetToDone { get; set; }
        public Nullable<System.DateTime> TimeDeactivated { get; set; }
    
    }
}
