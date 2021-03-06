﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstTodo
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
