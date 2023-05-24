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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FWorkspace));
            this.pnHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnCreateNewSpace = new System.Windows.Forms.Button();
            this.btnSpaces = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.flSpacesList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.flSpacesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.pnHead.Controls.Add(this.pictureBox1);
            this.pnHead.Controls.Add(this.btnExit);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1200, 52);
            this.pnHead.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1149, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelSideMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 651);
            this.panel2.TabIndex = 2;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.AutoSize = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.flSpacesList);
            this.panelSideMenu.Controls.Add(this.btnSpaces);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(355, 651);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // btnCreateNewSpace
            // 
            this.btnCreateNewSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateNewSpace.Location = new System.Drawing.Point(0, 0);
            this.btnCreateNewSpace.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnCreateNewSpace.Name = "btnCreateNewSpace";
            this.btnCreateNewSpace.Size = new System.Drawing.Size(320, 40);
            this.btnCreateNewSpace.TabIndex = 0;
            this.btnCreateNewSpace.Text = "+ New Space";
            this.btnCreateNewSpace.UseVisualStyleBackColor = true;
            this.btnCreateNewSpace.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpaces
            // 
            this.btnSpaces.Location = new System.Drawing.Point(0, 111);
            this.btnSpaces.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpaces.Name = "btnSpaces";
            this.btnSpaces.Size = new System.Drawing.Size(320, 74);
            this.btnSpaces.TabIndex = 1;
            this.btnSpaces.Text = "Spaces";
            this.btnSpaces.UseVisualStyleBackColor = true;
            this.btnSpaces.Click += new System.EventHandler(this.Space_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(349, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // flSpacesList
            // 
            this.flSpacesList.AutoScroll = true;
            this.flSpacesList.Controls.Add(this.btnCreateNewSpace);
            this.flSpacesList.Location = new System.Drawing.Point(0, 200);
            this.flSpacesList.Margin = new System.Windows.Forms.Padding(0);
            this.flSpacesList.Name = "flSpacesList";
            this.flSpacesList.Size = new System.Drawing.Size(352, 59);
            this.flSpacesList.TabIndex = 3;
            // 
            // FWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FWorkspace";
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.pnHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.flSpacesList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCreateNewSpace;
        private System.Windows.Forms.Button btnSpaces;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel flSpacesList;
    }
}

