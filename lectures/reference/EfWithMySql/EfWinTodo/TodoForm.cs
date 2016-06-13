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

        private void SetDefaultRowValues(DataGridViewCell newTimeCreatedCell, DataGridViewCell newDoneCell)
        {
            newTimeCreatedCell.Value = DateTime.Now;
            newDoneCell.Value = false;
        }

    }
}
