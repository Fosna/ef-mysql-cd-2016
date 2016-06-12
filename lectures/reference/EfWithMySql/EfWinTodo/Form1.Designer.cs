namespace EfWinTodo
{
    partial class Form1
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
            this.todoDataSource = new EFWinforms.EntityDataSource(this.components);
            this.todoBindingNavigator = new EFWinforms.EntityBindingNavigator();
            this.todoGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSetToDoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.todoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // todoDataSource
            // 
            this.todoDataSource.DbContextType = typeof(EfCodeFirstTodo.TodoEntities);
            // 
            // todoBindingNavigator
            // 
            this.todoBindingNavigator.DataMember = "TodoItems";
            this.todoBindingNavigator.DataSource = this.todoDataSource;
            this.todoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.todoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.todoBindingNavigator.Name = "todoBindingNavigator";
            this.todoBindingNavigator.Size = new System.Drawing.Size(669, 27);
            this.todoBindingNavigator.TabIndex = 0;
            this.todoBindingNavigator.Text = "entityBindingNavigator1";
            // 
            // todoGridView
            // 
            this.todoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoGridView.AutoGenerateColumns = false;
            this.todoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeCreatedDataGridViewTextBoxColumn,
            this.timeSetToDoneDataGridViewTextBoxColumn});
            this.todoGridView.DataMember = "TodoItems";
            this.todoGridView.DataSource = this.todoDataSource;
            this.todoGridView.Location = new System.Drawing.Point(0, 31);
            this.todoGridView.Name = "todoGridView";
            this.todoGridView.RowTemplate.Height = 24;
            this.todoGridView.Size = new System.Drawing.Size(669, 451);
            this.todoGridView.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 482);
            this.Controls.Add(this.todoGridView);
            this.Controls.Add(this.todoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.todoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EFWinforms.EntityDataSource todoDataSource;
        private EFWinforms.EntityBindingNavigator todoBindingNavigator;
        private System.Windows.Forms.DataGridView todoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSetToDoneDataGridViewTextBoxColumn;
    }
}

