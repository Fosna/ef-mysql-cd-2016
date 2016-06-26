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
            this.todoEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todoItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSetToDoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDeactivatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource1)).BeginInit();
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
            this.timeCreatedDataGridViewTextBoxColumn,
            this.timeSetToDoneDataGridViewTextBoxColumn,
            this.timeDeactivatedDataGridViewTextBoxColumn});
            this.dgvTodo.DataSource = this.todoItemBindingSource;
            this.dgvTodo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTodo.Location = new System.Drawing.Point(10, 33);
            this.dgvTodo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTodo.MultiSelect = false;
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowTemplate.Height = 24;
            this.dgvTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodo.Size = new System.Drawing.Size(238, 294);
            this.dgvTodo.TabIndex = 0;
            this.dgvTodo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(442, 300);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 300);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(192, 10);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 19);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(254, 33);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(246, 114);
            this.txtDescription.TabIndex = 5;
            // 
            // dtpTimeCreated
            // 
            this.dtpTimeCreated.Enabled = false;
            this.dtpTimeCreated.Location = new System.Drawing.Point(349, 174);
            this.dtpTimeCreated.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeCreated.Name = "dtpTimeCreated";
            this.dtpTimeCreated.Size = new System.Drawing.Size(151, 20);
            this.dtpTimeCreated.TabIndex = 6;
            // 
            // cbxDone
            // 
            this.cbxDone.AutoSize = true;
            this.cbxDone.Location = new System.Drawing.Point(254, 151);
            this.cbxDone.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDone.Name = "cbxDone";
            this.cbxDone.Size = new System.Drawing.Size(58, 17);
            this.cbxDone.TabIndex = 7;
            this.cbxDone.Text = "Done?";
            this.cbxDone.UseVisualStyleBackColor = true;
            // 
            // dtpTimeSetToDone
            // 
            this.dtpTimeSetToDone.Enabled = false;
            this.dtpTimeSetToDone.Location = new System.Drawing.Point(349, 197);
            this.dtpTimeSetToDone.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTimeSetToDone.Name = "dtpTimeSetToDone";
            this.dtpTimeSetToDone.Size = new System.Drawing.Size(151, 20);
            this.dtpTimeSetToDone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time Created:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time Set to Done:";
            // 
            // todoEntitiesBindingSource
            // 
            this.todoEntitiesBindingSource.DataSource = typeof(WfTodo.TodoEntities);
            // 
            // todoItemBindingSource
            // 
            this.todoItemBindingSource.DataSource = typeof(WfTodo.TodoItem);
            // 
            // todoItemBindingSource1
            // 
            this.todoItemBindingSource1.DataSource = typeof(WfTodo.TodoItem);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // timeSetToDoneDataGridViewTextBoxColumn
            // 
            this.timeSetToDoneDataGridViewTextBoxColumn.DataPropertyName = "TimeSetToDone";
            this.timeSetToDoneDataGridViewTextBoxColumn.HeaderText = "TimeSetToDone";
            this.timeSetToDoneDataGridViewTextBoxColumn.Name = "timeSetToDoneDataGridViewTextBoxColumn";
            // 
            // timeDeactivatedDataGridViewTextBoxColumn
            // 
            this.timeDeactivatedDataGridViewTextBoxColumn.DataPropertyName = "TimeDeactivated";
            this.timeDeactivatedDataGridViewTextBoxColumn.HeaderText = "TimeDeactivated";
            this.timeDeactivatedDataGridViewTextBoxColumn.Name = "timeDeactivatedDataGridViewTextBoxColumn";
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 337);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TodoForm";
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.TodoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpTimeSetToDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource todoEntitiesBindingSource;
        private System.Windows.Forms.BindingSource todoItemBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSetToDoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDeactivatedDataGridViewTextBoxColumn;
    }
}

