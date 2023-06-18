namespace SE104_Project
{
    partial class FSpace_US_Setting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpaceName = new System.Windows.Forms.TextBox();
            this.lbWorkspace = new System.Windows.Forms.Label();
            this.lBPeopleList = new System.Windows.Forms.ListBox();
            this.cBAddPeople = new System.Windows.Forms.ComboBox();
            this.labelFor = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your Space name:";
            // 
            // tbSpaceName
            // 
            this.tbSpaceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpaceName.Location = new System.Drawing.Point(28, 108);
            this.tbSpaceName.Name = "tbSpaceName";
            this.tbSpaceName.Size = new System.Drawing.Size(370, 26);
            this.tbSpaceName.TabIndex = 11;
            // 
            // lbWorkspace
            // 
            this.lbWorkspace.AutoSize = true;
            this.lbWorkspace.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkspace.ForeColor = System.Drawing.Color.White;
            this.lbWorkspace.Location = new System.Drawing.Point(321, 16);
            this.lbWorkspace.Name = "lbWorkspace";
            this.lbWorkspace.Size = new System.Drawing.Size(186, 35);
            this.lbWorkspace.TabIndex = 10;
            this.lbWorkspace.Text = "Space Setting";
            // 
            // lBPeopleList
            // 
            this.lBPeopleList.FormattingEnabled = true;
            this.lBPeopleList.ItemHeight = 16;
            this.lBPeopleList.Location = new System.Drawing.Point(601, 171);
            this.lBPeopleList.Name = "lBPeopleList";
            this.lBPeopleList.Size = new System.Drawing.Size(231, 100);
            this.lBPeopleList.TabIndex = 19;
            this.lBPeopleList.Click += new System.EventHandler(this.lBPeopleList_Click);
            this.lBPeopleList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lBPeopleList_DrawItem);
            this.lBPeopleList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lBPeopleList_MouseMove);
            // 
            // cBAddPeople
            // 
            this.cBAddPeople.AllowDrop = true;
            this.cBAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBAddPeople.FormattingEnabled = true;
            this.cBAddPeople.Location = new System.Drawing.Point(601, 111);
            this.cBAddPeople.Name = "cBAddPeople";
            this.cBAddPeople.Size = new System.Drawing.Size(231, 24);
            this.cBAddPeople.Sorted = true;
            this.cBAddPeople.TabIndex = 21;
            this.cBAddPeople.SelectionChangeCommitted += new System.EventHandler(this.cBAddPeople_SelectionChangeCommitted);
            // 
            // labelFor
            // 
            this.labelFor.AutoSize = true;
            this.labelFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFor.ForeColor = System.Drawing.Color.White;
            this.labelFor.Location = new System.Drawing.Point(504, 111);
            this.labelFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(81, 18);
            this.labelFor.TabIndex = 20;
            this.labelFor.Text = "Add people";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(601, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 54);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(104, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 54);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Space";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FSpace_US_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cBAddPeople);
            this.Controls.Add(this.labelFor);
            this.Controls.Add(this.lBPeopleList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpaceName);
            this.Controls.Add(this.lbWorkspace);
            this.Name = "FSpace_US_Setting";
            this.Size = new System.Drawing.Size(901, 501);
            this.Load += new System.EventHandler(this.FSpace_US_Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpaceName;
        private System.Windows.Forms.Label lbWorkspace;
        private System.Windows.Forms.ListBox lBPeopleList;
        private System.Windows.Forms.ComboBox cBAddPeople;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}
