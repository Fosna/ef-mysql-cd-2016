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
            ShowTodoItemDetails();
        }

        private void ShowTodoItemDetails()
        {
            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItem selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItem selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    selectedTodo.Description = txtDescription.Text.Trim();
                    if (cbxDone.Checked)
                    {
                        selectedTodo.TimeSetToDone = DateTime.Now;
                    }
                    else
                    {
                        selectedTodo.TimeSetToDone = null;
                    }

                    MessageBox.Show("Todo item saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //+ 
            dgvTodo.Refresh();
            ShowTodoItemDetails();
        }

        private bool TryGetSelectedId(out int id)
        {
            if (dgvTodo.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTodo.SelectedRows[0];
                id = (int)selectedRow.Cells[0].Value;
                return true;
            }

            id = default(int);
            return false;
        }

        private bool TryGetSelectedTodoById(int id, out TodoItem selectedTodo)
        {
            selectedTodo = TodoItemList.SingleOrDefault(x => x.Id == id);

            if (selectedTodo == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowTodoItemDetails();
        }

        private void TodoForm_Load(object sender, EventArgs e)
        {
            ShowTodoItemDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var tiNew = new TodoItem();
            tiNew.Id = TodoItemList.Count + 1;
            tiNew.Description = txtDescription.Text;
            tiNew.TimeCreated = DateTime.Today;
            TodoItemList.Add(tiNew);

            MessageBox.Show("Todo item created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTodo.DataSource = null;
            dgvTodo.DataSource = TodoItemList;
            ShowTodoItemDetails();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var currTodo in TodoItemList)
            {
                if (currTodo.Id.ToString() == dgvTodo.CurrentRow.Cells[0].Value.ToString())
                {
                    TodoItemList.Remove(currTodo);
                    dgvTodo.DataSource = null;
                    dgvTodo.DataSource = TodoItemList;
                    ShowTodoItemDetails();
                    break;
                }
            }
        }
    }
}