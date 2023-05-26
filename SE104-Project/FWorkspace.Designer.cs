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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pnSlideBar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.flpSpace = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpace = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.pnHead.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnSlideBar.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1200, 47);
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
            this.btnMaximize.Location = new System.Drawing.Point(1119, 5);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMaximize.Size = new System.Drawing.Size(36, 38);
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
            this.btnMinimize.Location = new System.Drawing.Point(1078, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 38);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = global::SE104_Project.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(1160, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnMain);
            this.pnBody.Controls.Add(this.pnSlideBar);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 47);
            this.pnBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1200, 656);
            this.pnBody.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.panelChildForm);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(315, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(885, 656);
            this.pnMain.TabIndex = 1;
            this.pnMain.Resize += new System.EventHandler(this.pnMain_Resize);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(885, 578);
            this.panelChildForm.TabIndex = 0;
            // 
            // pnSlideBar
            // 
            this.pnSlideBar.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnSlideBar.Controls.Add(this.flowLayoutPanel1);
            this.pnSlideBar.Controls.Add(this.button2);
            this.pnSlideBar.Controls.Add(this.btnDashboard);
            this.pnSlideBar.Controls.Add(this.flpSpace);
            this.pnSlideBar.Controls.Add(this.btnSpace);
            this.pnSlideBar.Controls.Add(this.pn);
            this.pnSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSlideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSlideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnSlideBar.Name = "pnSlideBar";
            this.pnSlideBar.Size = new System.Drawing.Size(315, 656);
            this.pnSlideBar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Setting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 211);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(315, 55);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // flpSpace
            // 
            this.flpSpace.BackColor = System.Drawing.Color.SteelBlue;
            this.flpSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSpace.Location = new System.Drawing.Point(0, 211);
            this.flpSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpSpace.Name = "flpSpace";
            this.flpSpace.Size = new System.Drawing.Size(315, 0);
            this.flpSpace.TabIndex = 2;
            // 
            // btnSpace
            // 
            this.btnSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpace.Location = new System.Drawing.Point(0, 156);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(315, 55);
            this.btnSpace.TabIndex = 1;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // pn
            // 
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(315, 156);
            this.pn.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateTask);
            this.panel1.Location = new System.Drawing.Point(0, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 82);
            this.panel1.TabIndex = 1;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.BackColor = System.Drawing.Color.Navy;
            this.btnCreateTask.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateTask.Location = new System.Drawing.Point(30, 14);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(149, 56);
            this.btnCreateTask.TabIndex = 2;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = false;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // FWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.pnHead.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pnSlideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateTask;
    }
}

