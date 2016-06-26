namespace WfTodo
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
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnUndone = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgwShow = new System.Windows.Forms.DataGridView();
            this.lblHelp = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnRemoveAllDone = new System.Windows.Forms.Button();
            this.txtDescriptionShow = new System.Windows.Forms.TextBox();
            this.lblDescShow = new System.Windows.Forms.Label();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.dtpDateSetToDone = new System.Windows.Forms.DateTimePicker();
            this.lblDateSetDone = new System.Windows.Forms.Label();
            this.lblDateCreatedShow = new System.Windows.Forms.Label();
            this.todoItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(61, 49);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(43, 16);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "ToDo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(54, 437);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(85, 36);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnUndone
            // 
            this.btnUndone.Location = new System.Drawing.Point(54, 479);
            this.btnUndone.Name = "btnUndone";
            this.btnUndone.Size = new System.Drawing.Size(85, 36);
            this.btnUndone.TabIndex = 6;
            this.btnUndone.Text = "Undone";
            this.btnUndone.UseVisualStyleBackColor = true;
            this.btnUndone.Click += new System.EventHandler(this.btnUndone_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(53, 546);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(136, 38);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(338, 546);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(136, 38);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "Remove all";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(651, 546);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgwShow
            // 
            this.dgwShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShow.Location = new System.Drawing.Point(54, 68);
            this.dgwShow.Name = "dgwShow";
            this.dgwShow.RowTemplate.Height = 24;
            this.dgwShow.Size = new System.Drawing.Size(359, 294);
            this.dgwShow.TabIndex = 10;
            this.dgwShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwShow_CellClick);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(437, 49);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(37, 16);
            this.lblHelp.TabIndex = 12;
            this.lblHelp.Text = "Help";
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(440, 68);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(293, 149);
            this.txtHelp.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(159, 395);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(252, 395);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(161, 22);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // btnRemoveAllDone
            // 
            this.btnRemoveAllDone.Location = new System.Drawing.Point(195, 546);
            this.btnRemoveAllDone.Name = "btnRemoveAllDone";
            this.btnRemoveAllDone.Size = new System.Drawing.Size(136, 38);
            this.btnRemoveAllDone.TabIndex = 17;
            this.btnRemoveAllDone.Text = "Remove all done";
            this.btnRemoveAllDone.UseVisualStyleBackColor = true;
            this.btnRemoveAllDone.Click += new System.EventHandler(this.btnRemoveAllDone_Click);
            // 
            // txtDescriptionShow
            // 
            this.txtDescriptionShow.Location = new System.Drawing.Point(557, 245);
            this.txtDescriptionShow.Name = "txtDescriptionShow";
            this.txtDescriptionShow.ReadOnly = true;
            this.txtDescriptionShow.Size = new System.Drawing.Size(176, 22);
            this.txtDescriptionShow.TabIndex = 18;
            // 
            // lblDescShow
            // 
            this.lblDescShow.AutoSize = true;
            this.lblDescShow.Location = new System.Drawing.Point(437, 245);
            this.lblDescShow.Name = "lblDescShow";
            this.lblDescShow.Size = new System.Drawing.Size(76, 16);
            this.lblDescShow.TabIndex = 19;
            this.lblDescShow.Text = "Description";
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Enabled = false;
            this.dtpDateCreated.Location = new System.Drawing.Point(557, 295);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateCreated.Size = new System.Drawing.Size(176, 22);
            this.dtpDateCreated.TabIndex = 20;
            // 
            // dtpDateSetToDone
            // 
            this.dtpDateSetToDone.Enabled = false;
            this.dtpDateSetToDone.Location = new System.Drawing.Point(557, 343);
            this.dtpDateSetToDone.Name = "dtpDateSetToDone";
            this.dtpDateSetToDone.Size = new System.Drawing.Size(176, 22);
            this.dtpDateSetToDone.TabIndex = 21;
            // 
            // lblDateSetDone
            // 
            this.lblDateSetDone.AutoSize = true;
            this.lblDateSetDone.Location = new System.Drawing.Point(437, 343);
            this.lblDateSetDone.Name = "lblDateSetDone";
            this.lblDateSetDone.Size = new System.Drawing.Size(96, 16);
            this.lblDateSetDone.TabIndex = 24;
            this.lblDateSetDone.Text = "Date Set Done";
            // 
            // lblDateCreatedShow
            // 
            this.lblDateCreatedShow.AutoSize = true;
            this.lblDateCreatedShow.Location = new System.Drawing.Point(437, 295);
            this.lblDateCreatedShow.Name = "lblDateCreatedShow";
            this.lblDateCreatedShow.Size = new System.Drawing.Size(88, 16);
            this.lblDateCreatedShow.TabIndex = 25;
            this.lblDateCreatedShow.Text = "Date Created";
            // 
            // todoItemsBindingSource
            // 
            this.todoItemsBindingSource.DataSource = typeof(WfTodo.TodoItems);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(338, 423);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(73, 36);
            this.btnCancle.TabIndex = 26;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 655);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.lblDateCreatedShow);
            this.Controls.Add(this.lblDateSetDone);
            this.Controls.Add(this.dtpDateSetToDone);
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.lblDescShow);
            this.Controls.Add(this.txtDescriptionShow);
            this.Controls.Add(this.btnRemoveAllDone);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.dgwShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUndone);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblListTitle);
            this.Name = "Form1";
            this.Text = "ToDo";
            ((System.ComponentModel.ISupportInitialize)(this.dgwShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnUndone;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgwShow;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.BindingSource todoItemsBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnRemoveAllDone;
        private System.Windows.Forms.TextBox txtDescriptionShow;
        private System.Windows.Forms.Label lblDescShow;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.DateTimePicker dtpDateSetToDone;
        private System.Windows.Forms.Label lblDateSetDone;
        private System.Windows.Forms.Label lblDateCreatedShow;
        private System.Windows.Forms.Button btnCancle;
    }
}

