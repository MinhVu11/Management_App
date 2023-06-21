namespace SE104_Project
{
    partial class FShareTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShare = new System.Windows.Forms.Button();
            this.cBAddPeople = new System.Windows.Forms.ComboBox();
            this.lBPeopleList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Share this task!";
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(322, 51);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(75, 27);
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // cBAddPeople
            // 
            this.cBAddPeople.AllowDrop = true;
            this.cBAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBAddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAddPeople.FormattingEnabled = true;
            this.cBAddPeople.Location = new System.Drawing.Point(12, 51);
            this.cBAddPeople.Name = "cBAddPeople";
            this.cBAddPeople.Size = new System.Drawing.Size(290, 26);
            this.cBAddPeople.Sorted = true;
            this.cBAddPeople.TabIndex = 34;
            this.cBAddPeople.SelectionChangeCommitted += new System.EventHandler(this.cBAddPeople_SelectionChangeCommitted);
            // 
            // lBPeopleList
            // 
            this.lBPeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBPeopleList.FormattingEnabled = true;
            this.lBPeopleList.ItemHeight = 18;
            this.lBPeopleList.Location = new System.Drawing.Point(12, 102);
            this.lBPeopleList.Name = "lBPeopleList";
            this.lBPeopleList.Size = new System.Drawing.Size(290, 184);
            this.lBPeopleList.TabIndex = 35;
            this.lBPeopleList.Click += new System.EventHandler(this.lBPeopleList_Click);
            this.lBPeopleList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lBPeopleList_DrawItem);
            this.lBPeopleList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lBPeopleList_MouseMove);
            // 
            // FShareTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 301);
            this.Controls.Add(this.lBPeopleList);
            this.Controls.Add(this.cBAddPeople);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FShareTask";
            this.Text = "FShareTask";
            this.Load += new System.EventHandler(this.FShareTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.ComboBox cBAddPeople;
        private System.Windows.Forms.ListBox lBPeopleList;
    }
}