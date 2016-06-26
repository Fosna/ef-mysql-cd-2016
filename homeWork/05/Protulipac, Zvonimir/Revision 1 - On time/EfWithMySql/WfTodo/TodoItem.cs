using System;

namespace WfTodo
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime? TimeSetToDone { get; set; }
        public DateTime? TimeDeactivated { get; set; }
    }
}