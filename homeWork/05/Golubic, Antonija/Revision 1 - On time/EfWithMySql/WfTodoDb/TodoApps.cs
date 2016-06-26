using System;
using System.Linq;

namespace WfTodoDb
{

    public class TodoApp
    {
        private TodoEntities db;

        public object Controls { get; private set; }

        public TodoApp()
        {
            this.db = new TodoEntities();
        }

        public void RemoveAll()
        {
            var all = this.db.TodoItems.ToList();

            foreach (var todoItem in all)
            {
                todoItem.TimeDeactivated = DateTime.Now;
            }
            System.Windows.Forms.MessageBox.Show("All Todo items removed.", "Success", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            this.db.SaveChanges();
        }

        public void SetDone()
        {
            
        }

        //public void Remove()
        //{
        //    int id;
        //    if (TryReadId(out id))
        //    {
        //        var deleteMe = db.TodoItems.SingleOrDefault(x => x.Id == id);
        //        if (deleteMe != null)
        //        {
        //            deleteMe.TimeDeactivated = DateTime.Now;
        //            this.db.SaveChanges();

        //            System.Windows.Forms.MessageBox.Show("Todo item removed.", "Success", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

        //        }
        //        else
        //        {
        //            System.Windows.Forms.MessageBox.Show("Todo item not found. Please enter valid todo item id..", "Warning!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        //        }
        //    }
        //}

        

        public void Add()
        {
            try
            {
                Console.Write("Description>");
                var description = Console.ReadLine().Trim();

                var addMe = new TodoItem();
                addMe.Description = description;
                addMe.TimeCreated = DateTime.Now;

                this.db.TodoItems.Add(addMe);
                this.db.SaveChanges();

                Console.WriteLine("Todo item has been added.");
            }
            catch (Exception x)
            {
                throw;
            }
        }

        //public void Undone()
        //{
        //    int id;
        //    if (TryReadId(out id))
        //    {
        //        var setMeToUndone = db.TodoItems.SingleOrDefault(x => x.Id == id);
        //        if (setMeToUndone != null)
        //        {
        //            setMeToUndone.TimeSetToDone = null;
        //            this.db.SaveChanges();

        //            Console.WriteLine("Todo items undone.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Todo item not found. Please enter valid todo item id.");
        //        }
        //    }
        //}

    }
}