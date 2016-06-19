using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfTodo
{
    public partial class TodoForm : Form
    {
        List<TodoItem> TodoItemList; 

        public TodoForm()
        {
            InitializeComponent();

            // Seed todo items.
            var firstTodo = new TodoItem();
            firstTodo.Id = 1;
            firstTodo.Description = "first";
            firstTodo.TimeCreated = DateTime.Now;

            var secondTodo = new TodoItem();
            secondTodo.Id = 2;
            secondTodo.Description = "second";
            secondTodo.TimeCreated = DateTime.Now;

            var thirdTodo = new TodoItem();
            thirdTodo.Id = 3;
            thirdTodo.Description = "third";
            thirdTodo.TimeCreated = DateTime.Now.AddDays(-2);
            thirdTodo.TimeSetToDone = DateTime.Now.AddDays(-1);

            TodoItemList = new List<TodoItem>();
            TodoItemList.Add(firstTodo);
            TodoItemList.Add(secondTodo);
            TodoItemList.Add(thirdTodo);

            dgvTodo.DataSource = TodoItemList;
        }

        private void dgvTodo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTodo.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTodo.SelectedRows[0];
                var id = (int)selectedRow.Cells[0].Value;

                var selectedTodo = TodoItemList.Single(x => x.Id == id);

                txtDescription.Text = selectedTodo.Description;
                cbxDone.Checked = selectedTodo.TimeSetToDone.HasValue;
                dtpTimeCreated.Value = selectedTodo.TimeCreated;
                if (selectedTodo.TimeSetToDone.HasValue)
                {
                    dtpTimeSetToDone.Value = selectedTodo.TimeSetToDone.Value;
                    dtpTimeSetToDone.Visible = true;
                }
                else
                {
                    dtpTimeSetToDone.Visible = false;
                }
                
            }
        }
    }
}
