namespace WfTodoDb
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
            this.dgwShow = new System.Windows.Forms.DataGridView();
            this.lblToDo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnUndone = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAllDone = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateSetToDone = new System.Windows.Forms.Label();
            this.txtDescShow = new System.Windows.Forms.TextBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.dtpDateSetToDone = new System.Windows.Forms.DateTimePicker();
            this.lblDescriptionAdd = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwShow
            // 
            this.dgwShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShow.Location = new System.Drawing.Point(15, 33);
            this.dgwShow.Name = "dgwShow";
            this.dgwShow.RowTemplate.Height = 24;
            this.dgwShow.Size = new System.Drawing.Size(413, 304);
            this.dgwShow.TabIndex = 0;
            this.dgwShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwShow_CellClick);
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(12, 14);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(43, 16);
            this.lblToDo.TabIndex = 1;
            this.lblToDo.Text = "ToDo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(23, 410);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 35);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnUndone
            // 
            this.btnUndone.Location = new System.Drawing.Point(23, 463);
            this.btnUndone.Name = "btnUndone";
            this.btnUndone.Size = new System.Drawing.Size(75, 35);
            this.btnUndone.TabIndex = 4;
            this.btnUndone.Text = "Undone";
            this.btnUndone.UseVisualStyleBackColor = true;
            this.btnUndone.Click += new System.EventHandler(this.btnUndone_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(23, 517);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAllDone
            // 
            this.btnRemoveAllDone.Location = new System.Drawing.Point(197, 517);
            this.btnRemoveAllDone.Name = "btnRemoveAllDone";
            this.btnRemoveAllDone.Size = new System.Drawing.Size(150, 35);
            this.btnRemoveAllDone.TabIndex = 6;
            this.btnRemoveAllDone.Text = "Remove all done";
            this.btnRemoveAllDone.UseVisualStyleBackColor = true;
            this.btnRemoveAllDone.Click += new System.EventHandler(this.btnRemoveAllDone_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(368, 517);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(150, 35);
            this.btnRemoveAll.TabIndex = 7;
            this.btnRemoveAll.Text = "Remove all ";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(719, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(227, 359);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(201, 22);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(465, 33);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(329, 180);
            this.txtHelp.TabIndex = 11;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(462, 272);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(88, 16);
            this.lblDateCreated.TabIndex = 13;
            this.lblDateCreated.Text = "Date Created";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // lblDateSetToDone
            // 
            this.lblDateSetToDone.AutoSize = true;
            this.lblDateSetToDone.Location = new System.Drawing.Point(462, 315);
            this.lblDateSetToDone.Name = "lblDateSetToDone";
            this.lblDateSetToDone.Size = new System.Drawing.Size(116, 16);
            this.lblDateSetToDone.TabIndex = 15;
            this.lblDateSetToDone.Text = "Date Set To Done";
            // 
            // txtDescShow
            // 
            this.txtDescShow.Location = new System.Drawing.Point(622, 232);
            this.txtDescShow.Name = "txtDescShow";
            this.txtDescShow.ReadOnly = true;
            this.txtDescShow.Size = new System.Drawing.Size(172, 22);
            this.txtDescShow.TabIndex = 16;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Enabled = false;
            this.dtpDateCreated.Location = new System.Drawing.Point(622, 272);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(172, 22);
            this.dtpDateCreated.TabIndex = 17;
            // 
            // dtpDateSetToDone
            // 
            this.dtpDateSetToDone.Enabled = false;
            this.dtpDateSetToDone.Location = new System.Drawing.Point(622, 315);
            this.dtpDateSetToDone.Name = "dtpDateSetToDone";
            this.dtpDateSetToDone.Size = new System.Drawing.Size(172, 22);
            this.dtpDateSetToDone.TabIndex = 18;
            // 
            // lblDescriptionAdd
            // 
            this.lblDescriptionAdd.AutoSize = true;
            this.lblDescriptionAdd.Location = new System.Drawing.Point(145, 362);
            this.lblDescriptionAdd.Name = "lblDescriptionAdd";
            this.lblDescriptionAdd.Size = new System.Drawing.Size(76, 16);
            this.lblDescriptionAdd.TabIndex = 19;
            this.lblDescriptionAdd.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 600);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescriptionAdd);
            this.Controls.Add(this.dtpDateSetToDone);
            this.Controls.Add(this.dtpDateCreated);
            this.Controls.Add(this.txtDescShow);
            this.Controls.Add(this.lblDateSetToDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveAllDone);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUndone);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.dgwShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwShow;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnUndone;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAllDone;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateSetToDone;
        private System.Windows.Forms.TextBox txtDescShow;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.DateTimePicker dtpDateSetToDone;
        private System.Windows.Forms.Label lblDescriptionAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}

