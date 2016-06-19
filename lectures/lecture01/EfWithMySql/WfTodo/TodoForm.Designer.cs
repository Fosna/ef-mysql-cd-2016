namespace WfTodo
{
    partial class TodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpTimeCreated = new System.Windows.Forms.DateTimePicker();
            this.cbxDone = new System.Windows.Forms.CheckBox();
            this.dtpTimeSetToDone = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodo
            // 
            this.dgvTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTodo.AutoGenerateColumns = false;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeCreatedDataGridViewTextBoxColumn});
            this.dgvTodo.DataSource = this.todoItemBindingSource;
            this.dgvTodo.Location = new System.Drawing.Point(13, 41);
            this.dgvTodo.MultiSelect = false;
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowTemplate.Height = 24;
            this.dgvTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodo.Size = new System.Drawing.Size(318, 362);
            this.dgvTodo.TabIndex = 0;
            this.dgvTodo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(590, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(338, 41);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(327, 140);
            this.txtDescription.TabIndex = 5;
            // 
            // dtpTimeCreated
            // 
            this.dtpTimeCreated.Enabled = false;
            this.dtpTimeCreated.Location = new System.Drawing.Point(465, 214);
            this.dtpTimeCreated.Name = "dtpTimeCreated";
            this.dtpTimeCreated.Size = new System.Drawing.Size(200, 22);
            this.dtpTimeCreated.TabIndex = 6;
            // 
            // cbxDone
            // 
            this.cbxDone.AutoSize = true;
            this.cbxDone.Location = new System.Drawing.Point(338, 187);
            this.cbxDone.Name = "cbxDone";
            this.cbxDone.Size = new System.Drawing.Size(72, 21);
            this.cbxDone.TabIndex = 7;
            this.cbxDone.Text = "Done?";
            this.cbxDone.UseVisualStyleBackColor = true;
            // 
            // dtpTimeSetToDone
            // 
            this.dtpTimeSetToDone.Enabled = false;
            this.dtpTimeSetToDone.Location = new System.Drawing.Point(465, 242);
            this.dtpTimeSetToDone.Name = "dtpTimeSetToDone";
            this.dtpTimeSetToDone.Size = new System.Drawing.Size(200, 22);
            this.dtpTimeSetToDone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time Created:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time Set To Done:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // timeCreatedDataGridViewTextBoxColumn
            // 
            this.timeCreatedDataGridViewTextBoxColumn.DataPropertyName = "TimeCreated";
            this.timeCreatedDataGridViewTextBoxColumn.HeaderText = "TimeCreated";
            this.timeCreatedDataGridViewTextBoxColumn.Name = "timeCreatedDataGridViewTextBoxColumn";
            // 
            // todoItemBindingSource
            // 
            this.todoItemBindingSource.DataSource = typeof(WfTodo.TodoItem);
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTimeSetToDone);
            this.Controls.Add(this.cbxDone);
            this.Controls.Add(this.dtpTimeCreated);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTodo);
            this.Name = "TodoForm";
            this.Text = "Todo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource todoItemBindingSource;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpTimeCreated;
        private System.Windows.Forms.CheckBox cbxDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpTimeSetToDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

