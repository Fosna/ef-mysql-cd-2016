using EfCodeFirstTodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetStuff.Dump;
using System.Diagnostics;

namespace EfWinTodo
{
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
        }

        private void todoGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var newTimeCreatedCell = e.Row.Cells["timeCreatedDataGridViewTextBoxColumn"];
            var newDoneCell = e.Row.Cells["isDoneDataGridViewCheckBoxColumn"];

            SetDefaultRowValues(newTimeCreatedCell, newDoneCell);
        }

        /// <summary>
        /// When new row is created time created should be set to current time and task done flag should be set to false.
        /// </summary>
        /// <param name="newTimeCreatedCell"></param>
        /// <param name="newDoneCell"></param>
        private void SetDefaultRowValues(DataGridViewCell newTimeCreatedCell, DataGridViewCell newDoneCell)
        {
            newTimeCreatedCell.Value = DateTime.Now;
            newDoneCell.Value = false;
        }

        private void todoGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Persists is done checkbox change to underlaying datasource right after each click.
            // Without it user whould have to leave this cell before changes would be persisted to underlaying data source.
            if (this.todoGridView.IsCurrentCellDirty && 
                this.todoGridView.CurrentCell.OwningColumn.Name == "isDoneDataGridViewCheckBoxColumn")
            {
                this.todoGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
