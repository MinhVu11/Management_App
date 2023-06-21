namespace SE104_Project
{
    partial class FWorkspace
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
            this.pnHead = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnCreateTask = new System.Windows.Forms.Panel();
            this.pnSlideBar = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.flpSpace = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpace = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.pnHead.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnSlideBar.SuspendLayout();
            this.pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.pnHead.Controls.Add(this.btnMaximize);
            this.pnHead.Controls.Add(this.btnMinimize);
            this.pnHead.Controls.Add(this.btnExit);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1111, 30);
            this.pnHead.TabIndex = 0;
            this.pnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseDown);
            this.pnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseMove);
            this.pnHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.Image = global::SE104_Project.Properties.Resources.ic;
            this.btnMaximize.Location = new System.Drawing.Point(1057, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.Image = global::SE104_Project.Properties.Resources.mm;
            this.btnMinimize.Location = new System.Drawing.Point(1030, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = global::SE104_Project.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(1084, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnMain);
            this.pnBody.Controls.Add(this.pnSlideBar);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 30);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1111, 556);
            this.pnBody.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnCreateTask);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(210, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(901, 556);
            this.pnMain.TabIndex = 1;
            this.pnMain.Resize += new System.EventHandler(this.pnMain_Resize);
            // 
            // pnCreateTask
            // 
            this.pnCreateTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCreateTask.BackColor = System.Drawing.Color.White;
            this.pnCreateTask.Location = new System.Drawing.Point(794, 499);
            this.pnCreateTask.Name = "pnCreateTask";
            this.pnCreateTask.Size = new System.Drawing.Size(104, 54);
            this.pnCreateTask.TabIndex = 0;
            // 
            // pnSlideBar
            // 
            this.pnSlideBar.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnSlideBar.Controls.Add(this.btnSetting);
            this.pnSlideBar.Controls.Add(this.btnMeeting);
            this.pnSlideBar.Controls.Add(this.flpSpace);
            this.pnSlideBar.Controls.Add(this.btnSpace);
            this.pnSlideBar.Controls.Add(this.pn);
            this.pnSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSlideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSlideBar.Name = "pnSlideBar";
            this.pnSlideBar.Size = new System.Drawing.Size(210, 556);
            this.pnSlideBar.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(0, 521);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(210, 35);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMeeting
            // 
            this.btnMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeeting.Location = new System.Drawing.Point(0, 261);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(210, 47);
            this.btnMeeting.TabIndex = 3;
            this.btnMeeting.Text = "Meeting";
            this.btnMeeting.UseVisualStyleBackColor = true;
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            // 
            // flpSpace
            // 
            this.flpSpace.BackColor = System.Drawing.Color.SteelBlue;
            this.flpSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSpace.Location = new System.Drawing.Point(0, 261);
            this.flpSpace.Name = "flpSpace";
            this.flpSpace.Size = new System.Drawing.Size(210, 0);
            this.flpSpace.TabIndex = 2;
            // 
            // btnSpace
            // 
            this.btnSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(0, 214);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(210, 47);
            this.btnSpace.TabIndex = 1;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // pn
            // 
            this.pn.Controls.Add(this.btnHome);
            this.pn.Controls.Add(this.btnNotification);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(210, 214);
            this.pn.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 120);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 47);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.Black;
            this.btnNotification.Location = new System.Drawing.Point(0, 167);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(210, 47);
            this.btnNotification.TabIndex = 0;
            this.btnNotification.Text = "Notification";
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // FWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 586);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.pnHead.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnSlideBar.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnSlideBar;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.FlowLayoutPanel flpSpace;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Panel pnCreateTask;
        private System.Windows.Forms.Button btnHome;
    }
}
