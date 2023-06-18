namespace SE104_Project
{
    partial class FEditTask
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
            this.lBPeopleList = new System.Windows.Forms.ListBox();
            this.cBAddPeople = new System.Windows.Forms.ComboBox();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.cBIn = new System.Windows.Forms.ComboBox();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelFor = new System.Windows.Forms.Label();
            this.lableTaskDescription = new System.Windows.Forms.Label();
            this.rTBTaskDescription = new System.Windows.Forms.RichTextBox();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.lbTaskName = new System.Windows.Forms.Label();
            this.btnShare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBPeopleList
            // 
            this.lBPeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBPeopleList.FormattingEnabled = true;
            this.lBPeopleList.ItemHeight = 18;
            this.lBPeopleList.Location = new System.Drawing.Point(724, 215);
            this.lBPeopleList.Name = "lBPeopleList";
            this.lBPeopleList.Size = new System.Drawing.Size(231, 112);
            this.lBPeopleList.TabIndex = 34;
            // 
            // cBAddPeople
            // 
            this.cBAddPeople.AllowDrop = true;
            this.cBAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBAddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAddPeople.FormattingEnabled = true;
            this.cBAddPeople.Location = new System.Drawing.Point(138, 135);
            this.cBAddPeople.Name = "cBAddPeople";
            this.cBAddPeople.Size = new System.Drawing.Size(231, 26);
            this.cBAddPeople.Sorted = true;
            this.cBAddPeople.TabIndex = 33;
            // 
            // cBStatus
            // 
            this.cBStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBStatus.FormattingEnabled = true;
            this.cBStatus.Items.AddRange(new object[] {
            "Active",
            "Completed",
            "Cancelled",
            "On Hold"});
            this.cBStatus.Location = new System.Drawing.Point(722, 89);
            this.cBStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(232, 26);
            this.cBStatus.TabIndex = 32;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(654, 87);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 18);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Status";
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTask.Location = new System.Drawing.Point(722, 354);
            this.buttonCreateTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(231, 93);
            this.buttonCreateTask.TabIndex = 30;
            this.buttonCreateTask.Text = "Update";
            this.buttonCreateTask.UseVisualStyleBackColor = false;
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEndDate.Location = new System.Drawing.Point(341, 18);
            this.dTPEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(247, 24);
            this.dTPEndDate.TabIndex = 29;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.White;
            this.labelEndDate.Location = new System.Drawing.Point(246, 18);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(69, 18);
            this.labelEndDate.TabIndex = 28;
            this.labelEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.ForeColor = System.Drawing.Color.White;
            this.lbStartDate.Location = new System.Drawing.Point(44, 17);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(60, 18);
            this.lbStartDate.TabIndex = 26;
            this.lbStartDate.Text = "Created";
            // 
            // cBIn
            // 
            this.cBIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBIn.FormattingEnabled = true;
            this.cBIn.Location = new System.Drawing.Point(721, 138);
            this.cBIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBIn.Name = "cBIn";
            this.cBIn.Size = new System.Drawing.Size(232, 26);
            this.cBIn.TabIndex = 25;
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.ForeColor = System.Drawing.Color.White;
            this.labelIn.Location = new System.Drawing.Point(654, 138);
            this.labelIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(62, 18);
            this.labelIn.TabIndex = 24;
            this.labelIn.Text = "Move to";
            // 
            // labelFor
            // 
            this.labelFor.AutoSize = true;
            this.labelFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFor.ForeColor = System.Drawing.Color.White;
            this.labelFor.Location = new System.Drawing.Point(47, 135);
            this.labelFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(79, 18);
            this.labelFor.TabIndex = 23;
            this.labelFor.Text = "Assign For";
            // 
            // lableTaskDescription
            // 
            this.lableTaskDescription.AutoSize = true;
            this.lableTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTaskDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lableTaskDescription.Location = new System.Drawing.Point(44, 183);
            this.lableTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableTaskDescription.Name = "lableTaskDescription";
            this.lableTaskDescription.Size = new System.Drawing.Size(120, 18);
            this.lableTaskDescription.TabIndex = 22;
            this.lableTaskDescription.Text = "Task Description";
            // 
            // rTBTaskDescription
            // 
            this.rTBTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBTaskDescription.Location = new System.Drawing.Point(47, 215);
            this.rTBTaskDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rTBTaskDescription.Name = "rTBTaskDescription";
            this.rTBTaskDescription.Size = new System.Drawing.Size(559, 209);
            this.rTBTaskDescription.TabIndex = 21;
            this.rTBTaskDescription.Text = "";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskName.Location = new System.Drawing.Point(50, 89);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(559, 24);
            this.tbTaskName.TabIndex = 20;
            // 
            // lbTaskName
            // 
            this.lbTaskName.AutoSize = true;
            this.lbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTaskName.Location = new System.Drawing.Point(44, 54);
            this.lbTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(85, 18);
            this.lbTaskName.TabIndex = 19;
            this.lbTaskName.Text = "Task Name";
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.White;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.Black;
            this.btnShare.Location = new System.Drawing.Point(878, 13);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(75, 28);
            this.btnShare.TabIndex = 35;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = false;
            // 
            // FEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1012, 459);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.lBPeopleList);
            this.Controls.Add(this.cBAddPeople);
            this.Controls.Add(this.cBStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.dTPEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.cBIn);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelFor);
            this.Controls.Add(this.lableTaskDescription);
            this.Controls.Add(this.rTBTaskDescription);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.lbTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FEditTask";
            this.Text = "FEditTask";
            this.Load += new System.EventHandler(this.FEditTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBPeopleList;
        private System.Windows.Forms.ComboBox cBAddPeople;
        private System.Windows.Forms.ComboBox cBStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.ComboBox cBIn;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Label lableTaskDescription;
        private System.Windows.Forms.RichTextBox rTBTaskDescription;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.Label lbTaskName;
        private System.Windows.Forms.Button btnShare;
    }
}