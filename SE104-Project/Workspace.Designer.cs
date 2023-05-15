namespace SE104_Project
{
    partial class Workspace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workspace));
            this.pnHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSpaces = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreateNewSpace = new System.Windows.Forms.Button();
            this.buttonSpaces = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panelSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.pnHead.Controls.Add(this.pictureBox1);
            this.pnHead.Controls.Add(this.btnExit);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(0, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(800, 33);
            this.pnHead.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(766, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 22);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMenu.Controls.Add(this.panel1);
            this.flowLayoutPanelMenu.Controls.Add(this.panelSpace);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(267, 417);
            this.flowLayoutPanelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 74);
            this.panel1.TabIndex = 0;
            // 
            // panelSpace
            // 
            this.panelSpace.Controls.Add(this.flowLayoutPanelSpaces);
            this.panelSpace.Controls.Add(this.buttonCreateNewSpace);
            this.panelSpace.Controls.Add(this.buttonSpaces);
            this.panelSpace.Location = new System.Drawing.Point(0, 74);
            this.panelSpace.Margin = new System.Windows.Forms.Padding(0);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(267, 51);
            this.panelSpace.TabIndex = 1;
            // 
            // flowLayoutPanelSpaces
            // 
            this.flowLayoutPanelSpaces.Location = new System.Drawing.Point(0, 102);
            this.flowLayoutPanelSpaces.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelSpaces.Name = "flowLayoutPanelSpaces";
            this.flowLayoutPanelSpaces.Size = new System.Drawing.Size(267, 12);
            this.flowLayoutPanelSpaces.TabIndex = 2;
            // 
            // buttonCreateNewSpace
            // 
            this.buttonCreateNewSpace.Location = new System.Drawing.Point(33, 67);
            this.buttonCreateNewSpace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateNewSpace.Name = "buttonCreateNewSpace";
            this.buttonCreateNewSpace.Size = new System.Drawing.Size(197, 28);
            this.buttonCreateNewSpace.TabIndex = 1;
            this.buttonCreateNewSpace.Text = "+ New Space";
            this.buttonCreateNewSpace.UseVisualStyleBackColor = true;
            this.buttonCreateNewSpace.Click += new System.EventHandler(this.buttonCreateNewSpace_Click);
            // 
            // buttonSpaces
            // 
            this.buttonSpaces.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSpaces.Location = new System.Drawing.Point(0, 0);
            this.buttonSpaces.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpaces.Name = "buttonSpaces";
            this.buttonSpaces.Size = new System.Drawing.Size(267, 51);
            this.buttonSpaces.TabIndex = 0;
            this.buttonSpaces.Text = "Spaces";
            this.buttonSpaces.UseVisualStyleBackColor = true;
            this.buttonSpaces.Click += new System.EventHandler(this.buttonSpaces_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(267, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 417);
            this.panel2.TabIndex = 2;
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.pnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workspace";
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            this.pnHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panelSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpaces;
        private System.Windows.Forms.Button buttonCreateNewSpace;
        private System.Windows.Forms.Button buttonSpaces;
        private System.Windows.Forms.Panel panel2;
    }
}

