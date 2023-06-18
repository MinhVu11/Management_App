namespace SE104_Project
{
    partial class FMeeting
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
            this.pnContainButton = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnMeetingList = new System.Windows.Forms.Button();
            this.btnNewMeeting = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnContainButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainButton
            // 
            this.pnContainButton.Controls.Add(this.btnCalendar);
            this.pnContainButton.Controls.Add(this.btnMeetingList);
            this.pnContainButton.Controls.Add(this.btnNewMeeting);
            this.pnContainButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainButton.Location = new System.Drawing.Point(0, 0);
            this.pnContainButton.Name = "pnContainButton";
            this.pnContainButton.Size = new System.Drawing.Size(901, 55);
            this.pnContainButton.TabIndex = 0;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.Black;
            this.btnCalendar.Location = new System.Drawing.Point(261, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(100, 55);
            this.btnCalendar.TabIndex = 7;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnMeetingList
            // 
            this.btnMeetingList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMeetingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeetingList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMeetingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeetingList.ForeColor = System.Drawing.Color.Black;
            this.btnMeetingList.Location = new System.Drawing.Point(140, 0);
            this.btnMeetingList.Name = "btnMeetingList";
            this.btnMeetingList.Size = new System.Drawing.Size(121, 55);
            this.btnMeetingList.TabIndex = 5;
            this.btnMeetingList.Text = "Meeting List";
            this.btnMeetingList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMeetingList.UseVisualStyleBackColor = false;
            this.btnMeetingList.Click += new System.EventHandler(this.btnMeetingList_Click);
            // 
            // btnNewMeeting
            // 
            this.btnNewMeeting.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNewMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMeeting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMeeting.ForeColor = System.Drawing.Color.Black;
            this.btnNewMeeting.Location = new System.Drawing.Point(0, 0);
            this.btnNewMeeting.Name = "btnNewMeeting";
            this.btnNewMeeting.Size = new System.Drawing.Size(140, 55);
            this.btnNewMeeting.TabIndex = 3;
            this.btnNewMeeting.Text = "New Meeting";
            this.btnNewMeeting.UseVisualStyleBackColor = false;
            this.btnNewMeeting.Click += new System.EventHandler(this.btnNewMeeting_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMain.Location = new System.Drawing.Point(0, 55);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(901, 501);
            this.pnMain.TabIndex = 1;
            // 
            // FMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 556);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnContainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMeeting";
            this.Text = "FMeeting";
            this.Load += new System.EventHandler(this.FMeeting_Load);
            this.pnContainButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainButton;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnNewMeeting;
        private System.Windows.Forms.Button btnMeetingList;
        private System.Windows.Forms.Button btnCalendar;
    }
}