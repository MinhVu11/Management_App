namespace SE104_Project
{
    partial class FSpace
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnContainButton = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.pnSpaceName = new System.Windows.Forms.Panel();
            this.lbSpaceName = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnContainButton.SuspendLayout();
            this.pnSpaceName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMain.Location = new System.Drawing.Point(0, 55);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(901, 501);
            this.pnMain.TabIndex = 0;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.Black;
            this.btnCalendar.Location = new System.Drawing.Point(205, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(100, 55);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.Black;
            this.btnList.Location = new System.Drawing.Point(0, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 55);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "To Do";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.pnContainButton);
            this.pnTop.Controls.Add(this.pnSpaceName);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(901, 55);
            this.pnTop.TabIndex = 1;
            // 
            // pnContainButton
            // 
            this.pnContainButton.BackColor = System.Drawing.Color.Gainsboro;
            this.pnContainButton.Controls.Add(this.btnSetting);
            this.pnContainButton.Controls.Add(this.btnCalendar);
            this.pnContainButton.Controls.Add(this.btnMeeting);
            this.pnContainButton.Controls.Add(this.btnList);
            this.pnContainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainButton.Location = new System.Drawing.Point(106, 0);
            this.pnContainButton.Name = "pnContainButton";
            this.pnContainButton.Size = new System.Drawing.Size(795, 55);
            this.pnContainButton.TabIndex = 4;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Location = new System.Drawing.Point(305, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(100, 55);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMeeting
            // 
            this.btnMeeting.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeeting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeeting.ForeColor = System.Drawing.Color.Black;
            this.btnMeeting.Location = new System.Drawing.Point(100, 0);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(105, 55);
            this.btnMeeting.TabIndex = 1;
            this.btnMeeting.Text = "Meeting";
            this.btnMeeting.UseVisualStyleBackColor = false;
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            // 
            // pnSpaceName
            // 
            this.pnSpaceName.BackColor = System.Drawing.Color.Gainsboro;
            this.pnSpaceName.Controls.Add(this.lbSpaceName);
            this.pnSpaceName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSpaceName.Location = new System.Drawing.Point(0, 0);
            this.pnSpaceName.Name = "pnSpaceName";
            this.pnSpaceName.Size = new System.Drawing.Size(106, 55);
            this.pnSpaceName.TabIndex = 4;
            // 
            // lbSpaceName
            // 
            this.lbSpaceName.AutoSize = true;
            this.lbSpaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpaceName.ForeColor = System.Drawing.Color.Black;
            this.lbSpaceName.Location = new System.Drawing.Point(22, 16);
            this.lbSpaceName.Name = "lbSpaceName";
            this.lbSpaceName.Size = new System.Drawing.Size(61, 22);
            this.lbSpaceName.TabIndex = 0;
            this.lbSpaceName.Text = "Name";
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 55);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(901, 1);
            this.pn.TabIndex = 2;
            // 
            // FSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(901, 556);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSpace";
            this.Text = "FSpace";
            this.Load += new System.EventHandler(this.FSpace_Load);
            this.pnTop.ResumeLayout(false);
            this.pnContainButton.ResumeLayout(false);
            this.pnSpaceName.ResumeLayout(false);
            this.pnSpaceName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnContainButton;
        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Panel pnSpaceName;
        private System.Windows.Forms.Label lbSpaceName;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Button btnSetting;
    }
}