using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfTodoDb
{
    public partial class Form1 : Form
     {
        private TodoEntities db;

        public Form1()
        {
            InitializeComponent();

            // Code review: Initialize db context one time.
            // Enables entity tracking.
            db = new TodoEntities();

            dgwShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwShow.RowHeadersVisible = false;
            dgwShow.AllowUserToAddRows = false;
            dgwShow.MultiSelect = false;
            dgwShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            hideTools();
            btnAdd.Focus();

            WriteHelp();
            List();
        }

        public void List()
        {
            // Code review. One db context per application is enough. No need to recreate it on every List() call.
            //this.db = new TodoEntities();
            var todoList = this.db.TodoItems.ToList();

            dgwShow.Columns.Add("rbr", "R. br.");
            dgwShow.Columns.Add("id", "ID");
            dgwShow.Columns.Add("description", "Description");
            dgwShow.Columns.Add("isDone", "Done?");

            int counter = 1;
            foreach (TodoItem todo in todoList)
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
            this.Close();
        }

        private void btnUndone_Click(object sender, EventArgs e)
        {
            hideTools();
            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItem selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    if (selectedTodo.TimeSetToDone != null)
                    {
                        selectedTodo.TimeSetToDone = null;
                        this.db.SaveChanges();
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
            // Code review: deactivate only todo items that aren't already deactivated.
            //var all = this.db.TodoItems.ToList();
            var activeTodoItems = this.db.TodoItems.Where(x => x.TimeDeactivated == null).ToList();

            foreach (var todoItem in activeTodoItems)
            {
                todoItem.TimeDeactivated = DateTime.Now;
            }
            MessageBox.Show("All Todo items removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.db.SaveChanges();
            txtDescShow.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            hideTools();
            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItem selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    selectedTodo.TimeSetToDone = DateTime.Now;
                    this.db.SaveChanges();
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

        public bool TryGetSelectedId(out int id)
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

        public bool TryGetSelectedTodoById(int id, out TodoItem selectedTodo)
        {
            selectedTodo = db.TodoItems.SingleOrDefault(x => x.Id == id);

            if (selectedTodo == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblDescriptionAdd.Visible = true;
            txtDescription.Visible = true;
            btnSave.Visible = true;
            txtDescription.Focus();
            btnCancel.Visible = true;
        }

        private void hideTools()
        {
            lblDescriptionAdd.Visible = false;
            txtDescription.Visible = false;
            txtDescription.Text = "";
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddItem();
            hideTools();
        }

        private void AddItem()
        {
            TodoItem addMe = new TodoItem();
            addMe.Description = txtDescription.Text;
            addMe.TimeCreated = DateTime.Now;

            this.db.TodoItems.Add(addMe);
            this.db.SaveChanges();

            MessageBox.Show("Todo item added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListClear();
            List();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddItem();
                hideTools();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            hideTools();

            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItem selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    selectedTodo.TimeDeactivated = DateTime.Now;
                    this.db.SaveChanges();
                    MessageBox.Show("Todo item removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Todo item not found. Please enter valid todo item id.");
                }
                ListClear();
                List();
                txtDescShow.Text = "";
            }
        }

        private void btnRemoveAllDone_Click(object sender, EventArgs e)
        {
            hideTools();

            this.db = new TodoEntities();
            var all = this.db.TodoItems.ToList();
            // Code review: consider fetching only done and active todo items.
            //var doneTodoItems = this.db.TodoItems.Where(x => x.TimeSetToDone.HasValue && x.TimeDeactivated == null).ToList();

            foreach (var todoItem in all)
            {
                // Code review: Bug fix. Already deactivated items shouldn't be deactivated again.
                if (todoItem.TimeSetToDone != null && todoItem.TimeDeactivated == null)
                {
                    todoItem.TimeDeactivated = DateTime.Now;
                    //this.db.SaveChanges();
                }
                // Code review: Proposed bug fix.
                //else
                //{
                //    todoItem.TimeDeactivated = null;
                //    this.db.SaveChanges();
                //}
            }
            // Code review: First do all the changes in memory. Then do one update to the database. This approach is considered as better practice becaus it generaly has better performance.
            this.db.SaveChanges();

            ListClear();
            List();
            txtDescShow.Text = "";
            MessageBox.Show("Done todo items removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hideTools();
        }

        private void WriteHelp()
        {
            // Code review: Try to find method that is better fit. Always check if file exists.
            //// Read each line of the file into a string array. Each element of the array is one line of the file.
            //string[] lines = System.IO.File.ReadAllLines(@"help.txt");

            //// Display the file contents by using a foreach loop.
            //foreach (string line in lines)
            //{
            //    txtHelp.Text += line + System.Environment.NewLine;
            //}

            var helpPath = "help.txt";
            if (System.IO.File.Exists(helpPath))
            {
                txtHelp.Text = System.IO.File.ReadAllText(helpPath);
            }
            else
            {
                MessageBox.Show("Help file not found!");
            }
        }

        private void ShowTodoItemDetails()
        {
            int id;
            if (TryGetSelectedId(out id))
            {
                TodoItem selectedTodo;
                if (TryGetSelectedTodoById(id, out selectedTodo))
                {
                    txtDescShow.Text = selectedTodo.Description;
                    dtpDateCreated.Value = selectedTodo.TimeCreated;
                    if (selectedTodo.TimeSetToDone.HasValue)
                    {
                        lblDateSetToDone.Visible = true;
                        dtpDateSetToDone.Visible = true;
                        dtpDateSetToDone.Value = selectedTodo.TimeSetToDone.Value;
                    }
                    else
                    {
                        lblDateSetToDone.Visible = false;
                        dtpDateSetToDone.Visible = false;
                    }
                }
            }
        }

        private void dgwShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowTodoItemDetails();
        }       
    }
}
