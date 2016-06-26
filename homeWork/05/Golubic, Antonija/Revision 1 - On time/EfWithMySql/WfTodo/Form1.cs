using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfTodo
{
    public partial class Form1 : Form
    {
        List<TodoItems> todoItems;

        public Form1()
        {
            InitializeComponent();

            todoItems = new List<TodoItems>();

            todoItems.Add(new TodoItems
            {
                Id = 1,
                Description = "Buy milk",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = DateTime.Now.AddDays(-1),
                TimeDeactivated = DateTime.Now.AddHours(-2),

            });
            todoItems.Add(new TodoItems
            {
                Id = 2,
                Description = "Homework",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
                TimeDeactivated = null
            });
            todoItems.Add(new TodoItems
            {
                Id = 3,
                Description = "gsdfds",
                TimeCreated = DateTime.Now.AddDays(-2),
                TimeSetToDone = null,
                TimeDeactivated = null
            });

            dgwShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwShow.RowHeadersVisible = false;
            dgwShow.AllowUserToAddRows = false;
            dgwShow.MultiSelect = false;
            dgwShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            hideTools();
            btnAdd.Focus();

            List();
            WriteHelp();
            ShowTodoItemDetails();
        }

        private void hideTools()
        {
            lblDescription.Visible = false;
            txtDescription.Visible = false;
            txtDescription.Text = "";
            btnSave.Visible = false;
            btnCancle.Visible = false;
        }

        public void List()
        {
            dgwShow.Columns.Add("rbr", "R. br.");
            dgwShow.Columns.Add("id", "ID");
            dgwShow.Columns.Add("description", "Description");
            dgwShow.Columns.Add("isDone", "Done?");

            int counter = 1;
            foreach (TodoItems todo in todoItems)
            {
                DataGridViewRow dgvr = new DataGridViewRow();

                dgvr.Cells.Add(new DataGridViewTextBoxCell());
                dgvr.Cells.Add(new DataGridViewTextBoxCell());
                dgvr.Cells.Add(new DataGridViewTextBoxCell());
                dgvr.Cells.Add(new DataGridViewTextBoxCell());

                if (todo.TimeDeactivated == null)
                {
                    if (todo.TimeSetToDone != null)
                    {
                        dgvr.Cells[3].Value = true;
                    }
                    else
                    {
                        dgvr.Cells[3].Value = false;
                    }

                    dgvr.Cells[0].Value = counter.ToString();
                    dgvr.Cells[1].Value = todo.Id;
                    dgvr.Cells[2].Value = todo.Description;

                    dgwShow.Rows.Add(dgvr);

                    dgwShow.Rows[0].Cells[0].Selected = true;
                    counter++;
                }
            }
        }

        public void ListClear()
        {
            dgwShow.Columns.Clear();
            dgwShow.Rows.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private TodoItems saveNewItem()
        {
            Random rnd = new Random();

            var desc = this.Controls.Find("txtDescription".ToString(), true)[0].Text;

                var description = new TodoItems
                {
                    Id = rnd.Next(1, 200),
                    Description = desc,
                    TimeCreated = DateTime.Now,
                    TimeSetToDone = null,
                    TimeDeactivated = null
                };
                return description;       
        }

        private void WriteHelp()
        {
            // Read each line of the file into a string array. Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Antonija\Documents\Visual Studio 2015\Projects\EfWithMySql\WfTodo\bin\Debug\help.txt");

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                txtHelp.Text += line + System.Environment.NewLine;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            btnSave.Visible = true;
            btnCancle.Visible = true;
            txtDescription.Focus();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ListClear();
                todoItems.Add(saveNewItem());
                List();
                hideTools();
                e.Handled = true; //no bip sound
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListClear();
            todoItems.Add(saveNewItem());
            List();
            hideTools();
        }

        private bool TryGetSelectedId(out int id)
        {
            if (dgwShow.SelectedRows.Count > 0)
            {
                var selectedRow = dgwShow.SelectedRows[0];
                id = (int)selectedRow.Cells[1].Value;
                return true;
            }

            id = default(int);
            return false;
        }

        private bool TryGetSelectedTodoById(int id, out TodoItems selectedTodo)
        {
            selectedTodo = todoItems.SingleOrDefault(x => x.Id == id);

            if (selectedTodo == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            hideTools();

            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItems selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    selectedTodo.TimeSetToDone = DateTime.Now;
                    MessageBox.Show("Todo item set to done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Todo item not found. Please enter valid todo item id.");
                }
                ListClear();
                List();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            hideTools();

            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItems selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    selectedTodo.TimeDeactivated = DateTime.Now;
                    MessageBox.Show("Todo item removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Todo item not found. Please enter valid todo item id.");
                }
                ListClear();
                List();
                txtDescriptionShow.Text = "";
            }
        }

        private void btnUndone_Click(object sender, EventArgs e)
        {
            hideTools();

            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItems selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    if (selectedTodo.TimeSetToDone != null)
                    {
                        selectedTodo.TimeSetToDone = null;
                        MessageBox.Show("Todo item set to undone.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Todo item is already set to undone.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }
                else
                {
                    MessageBox.Show("Todo item not found. Please enter valid todo item id.");
                }
                ListClear();
                List();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            hideTools();

            var all = todoItems;

            foreach (var todoItem in all)
            {
                todoItem.TimeDeactivated = DateTime.Now;
            }
            ListClear();
            List();
            txtDescriptionShow.Text = "";
            MessageBox.Show("All todo Items removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveAllDone_Click(object sender, EventArgs e)
        {
            hideTools();

            var all = todoItems;

            foreach (var todoItem in all)
            {
                if (todoItem.TimeSetToDone != null)
                {
                    todoItem.TimeDeactivated = DateTime.Now;
                }
                else
                {
                    todoItem.TimeDeactivated = null;
                }
            }
            ListClear();
            List();
            txtDescriptionShow.Text = "";
            MessageBox.Show("Done todo items removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowTodoItemDetails()
        {
            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItems selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    txtDescriptionShow.Text = selectedTodo.Description;
                    dtpDateCreated.Value = selectedTodo.TimeCreated;
                    if (selectedTodo.TimeSetToDone.HasValue)
                    {
                        lblDateSetDone.Visible = true;
                        dtpDateSetToDone.Visible = true;
                        dtpDateSetToDone.Value = selectedTodo.TimeSetToDone.Value;
                    }
                    else
                    {
                        lblDateSetDone.Visible = false;
                        dtpDateSetToDone.Visible = false;
                    }
                }
            }
        }

        private void dgwShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowTodoItemDetails();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            hideTools();
        }
    }
}
