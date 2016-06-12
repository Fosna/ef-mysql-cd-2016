﻿using System;
using System.Data.Entity;

namespace EfCodeFirstTodo
{
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
            context.TodoItems.Add(new TodoItem
            {
                Description = "Call Miki",
                TimeCreated = DateTime.Now.AddDays(-1),
                TimeSetToDone = null,
            });
            context.TodoItems.Add(new TodoItem
            {
                Description = "Do homework",
                TimeCreated = DateTime.Now.AddDays(-7),
                TimeSetToDone = DateTime.Now.AddDays(-2),
            });

            base.Seed(context);
        }
    }
}