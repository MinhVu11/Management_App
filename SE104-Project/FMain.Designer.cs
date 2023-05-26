namespace ManageProjectApp
{
    partial class FMain
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
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSpaces = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCreateNewSpace = new System.Windows.Forms.Button();
            this.buttonSpaces = new System.Windows.Forms.Button();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panelSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMenu.Controls.Add(this.panel1);
            this.flowLayoutPanelMenu.Controls.Add(this.panelSpace);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(400, 865);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 115);
            this.panel1.TabIndex = 0;
            // 
            // panelSpace
            // 
            this.panelSpace.Controls.Add(this.flowLayoutPanelSpaces);
            this.panelSpace.Controls.Add(this.buttonCreateNewSpace);
            this.panelSpace.Controls.Add(this.buttonSpaces);
            this.panelSpace.Location = new System.Drawing.Point(0, 115);
            this.panelSpace.Margin = new System.Windows.Forms.Padding(0);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(400, 80);
            this.panelSpace.TabIndex = 1;
            // 
            // flowLayoutPanelSpaces
            // 
            this.flowLayoutPanelSpaces.Location = new System.Drawing.Point(0, 160);
            this.flowLayoutPanelSpaces.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanelSpaces.Name = "flowLayoutPanelSpaces";
            this.flowLayoutPanelSpaces.Size = new System.Drawing.Size(400, 19);
            this.flowLayoutPanelSpaces.TabIndex = 2;
            // 
            // buttonCreateNewSpace
            // 
            this.buttonCreateNewSpace.Location = new System.Drawing.Point(49, 104);
            this.buttonCreateNewSpace.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateNewSpace.Name = "buttonCreateNewSpace";
            this.buttonCreateNewSpace.Size = new System.Drawing.Size(296, 44);
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
            this.buttonSpaces.Size = new System.Drawing.Size(400, 80);
            this.buttonSpaces.TabIndex = 0;
            this.buttonSpaces.Text = "Spaces";
            this.buttonSpaces.UseVisualStyleBackColor = true;
            this.buttonSpaces.Click += new System.EventHandler(this.buttonSpaces_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Z";
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panelSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Button buttonCreateNewSpace;
        private System.Windows.Forms.Button buttonSpaces;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSpaces;
    }
}

