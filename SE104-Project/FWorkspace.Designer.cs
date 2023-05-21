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
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnSlideBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.flpSpace = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpace = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnHead.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnSlideBar.SuspendLayout();
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
            this.pnHead.Size = new System.Drawing.Size(800, 30);
            this.pnHead.TabIndex = 0;
            this.pnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseDown);
            this.pnHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseMove);
            this.pnHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHead_MouseUp);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnMain);
            this.pnBody.Controls.Add(this.pnSlideBar);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 30);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(800, 420);
            this.pnBody.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(210, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(590, 420);
            this.pnMain.TabIndex = 1;
            this.pnMain.Resize += new System.EventHandler(this.pnMain_Resize);
            // 
            // pnSlideBar
            // 
            this.pnSlideBar.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnSlideBar.Controls.Add(this.button2);
            this.pnSlideBar.Controls.Add(this.btnDashboard);
            this.pnSlideBar.Controls.Add(this.flpSpace);
            this.pnSlideBar.Controls.Add(this.btnSpace);
            this.pnSlideBar.Controls.Add(this.pn);
            this.pnSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSlideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSlideBar.Name = "pnSlideBar";
            this.pnSlideBar.Size = new System.Drawing.Size(210, 420);
            this.pnSlideBar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Setting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Location = new System.Drawing.Point(0, 135);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 35);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // flpSpace
            // 
            this.flpSpace.BackColor = System.Drawing.Color.SteelBlue;
            this.flpSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSpace.Location = new System.Drawing.Point(0, 135);
            this.flpSpace.Name = "flpSpace";
            this.flpSpace.Size = new System.Drawing.Size(210, 0);
            this.flpSpace.TabIndex = 2;
            // 
            // btnSpace
            // 
            this.btnSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpace.Location = new System.Drawing.Point(0, 100);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(210, 35);
            this.btnSpace.TabIndex = 1;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // pn
            // 
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(210, 100);
            this.pn.TabIndex = 0;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.White;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.Image = global::SE104_Project.Properties.Resources.ic;
            this.btnMaximize.Location = new System.Drawing.Point(746, 3);
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
            this.btnMinimize.Location = new System.Drawing.Point(719, 3);
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
            this.btnExit.Location = new System.Drawing.Point(773, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWorkspace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.pnHead.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnSlideBar.ResumeLayout(false);
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
    }
}

