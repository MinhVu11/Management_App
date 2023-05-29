namespace SE104_Project
{
    partial class FCreateTask
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
            this.lbTaskName = new System.Windows.Forms.Label();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.rTBTaskDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lableTaskDescription = new System.Windows.Forms.Label();
            this.labelFor = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.cBIn = new System.Windows.Forms.ComboBox();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonCreateTask = new System.Windows.Forms.Button();
            this.cBStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cBAddPeople = new System.Windows.Forms.ComboBox();
            this.lBPeopleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTaskName
            // 
            this.lbTaskName.AutoSize = true;
            this.lbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTaskName.Location = new System.Drawing.Point(99, 41);
            this.lbTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(137, 29);
            this.lbTaskName.TabIndex = 0;
            this.lbTaskName.Text = "Task Name";
            // 
            // tbTaskName
            // 
            this.tbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaskName.Location = new System.Drawing.Point(105, 84);
            this.tbTaskName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(684, 35);
            this.tbTaskName.TabIndex = 1;
            // 
            // rTBTaskDescription
            // 
            this.rTBTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBTaskDescription.Location = new System.Drawing.Point(110, 278);
            this.rTBTaskDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rTBTaskDescription.Name = "rTBTaskDescription";
            this.rTBTaskDescription.Size = new System.Drawing.Size(767, 106);
            this.rTBTaskDescription.TabIndex = 2;
            this.rTBTaskDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 3;
            // 
            // lableTaskDescription
            // 
            this.lableTaskDescription.AutoSize = true;
            this.lableTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTaskDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lableTaskDescription.Location = new System.Drawing.Point(105, 225);
            this.lableTaskDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableTaskDescription.Name = "lableTaskDescription";
            this.lableTaskDescription.Size = new System.Drawing.Size(194, 29);
            this.lableTaskDescription.TabIndex = 4;
            this.lableTaskDescription.Text = "Task Description";
            // 
            // labelFor
            // 
            this.labelFor.AutoSize = true;
            this.labelFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFor.Location = new System.Drawing.Point(958, 154);
            this.labelFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(128, 29);
            this.labelFor.TabIndex = 5;
            this.labelFor.Text = "Assign For";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.Location = new System.Drawing.Point(105, 154);
            this.labelIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(32, 29);
            this.labelIn.TabIndex = 7;
            this.labelIn.Text = "In";
            // 
            // cBIn
            // 
            this.cBIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBIn.FormattingEnabled = true;
            this.cBIn.Location = new System.Drawing.Point(145, 151);
            this.cBIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBIn.Name = "cBIn";
            this.cBIn.Size = new System.Drawing.Size(232, 37);
            this.cBIn.TabIndex = 8;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(110, 459);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(118, 29);
            this.labelStartDate.TabIndex = 9;
            this.labelStartDate.Text = "Start Date";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartDate.Location = new System.Drawing.Point(236, 453);
            this.dTPStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(226, 35);
            this.dTPStartDate.TabIndex = 10;
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEndDate.Location = new System.Drawing.Point(649, 453);
            this.dTPEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(228, 35);
            this.dTPEndDate.TabIndex = 12;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(529, 458);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(112, 29);
            this.labelEndDate.TabIndex = 11;
            this.labelEndDate.Text = "End Date";
            // 
            // buttonCreateTask
            // 
            this.buttonCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTask.Location = new System.Drawing.Point(987, 504);
            this.buttonCreateTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateTask.Name = "buttonCreateTask";
            this.buttonCreateTask.Size = new System.Drawing.Size(255, 93);
            this.buttonCreateTask.TabIndex = 13;
            this.buttonCreateTask.Text = "Create";
            this.buttonCreateTask.UseVisualStyleBackColor = false;
            this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
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
            this.cBStatus.Location = new System.Drawing.Point(909, 84);
            this.cBStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBStatus.Name = "cBStatus";
            this.cBStatus.Size = new System.Drawing.Size(232, 37);
            this.cBStatus.TabIndex = 15;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(822, 87);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(79, 29);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Status";
            // 
            // cBAddPeople
            // 
            this.cBAddPeople.AllowDrop = true;
            this.cBAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBAddPeople.FormattingEnabled = true;
            this.cBAddPeople.Location = new System.Drawing.Point(910, 192);
            this.cBAddPeople.Name = "cBAddPeople";
            this.cBAddPeople.Size = new System.Drawing.Size(231, 37);
            this.cBAddPeople.Sorted = true;
            this.cBAddPeople.TabIndex = 17;
            this.cBAddPeople.SelectionChangeCommitted += new System.EventHandler(this.cBAddPeople_SelectionChangeCommitted);
            // 
            // lBPeopleList
            // 
            this.lBPeopleList.FormattingEnabled = true;
            this.lBPeopleList.ItemHeight = 29;
            this.lBPeopleList.Location = new System.Drawing.Point(910, 235);
            this.lBPeopleList.Name = "lBPeopleList";
            this.lBPeopleList.Size = new System.Drawing.Size(231, 149);
            this.lBPeopleList.TabIndex = 18;
            // 
            // FCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1279, 628);
            this.Controls.Add(this.lBPeopleList);
            this.Controls.Add(this.cBAddPeople);
            this.Controls.Add(this.cBStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonCreateTask);
            this.Controls.Add(this.dTPEndDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.cBIn);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelFor);
            this.Controls.Add(this.lableTaskDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTBTaskDescription);
            this.Controls.Add(this.tbTaskName);
            this.Controls.Add(this.lbTaskName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FCreateTask";
            this.Text = "Create New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaskName;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.RichTextBox rTBTaskDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lableTaskDescription;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.ComboBox cBIn;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.ComboBox cBStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox lBPeopleList;
        private System.Windows.Forms.ComboBox cBAddPeople;
    }
}