namespace SE104_Project
{
    partial class FSetting_US_Workspace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWorkspace = new System.Windows.Forms.Label();
            this.flpWorkspaces = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbWorkspace
            // 
            this.lbWorkspace.AutoSize = true;
            this.lbWorkspace.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkspace.ForeColor = System.Drawing.Color.White;
            this.lbWorkspace.Location = new System.Drawing.Point(30, 22);
            this.lbWorkspace.Name = "lbWorkspace";
            this.lbWorkspace.Size = new System.Drawing.Size(213, 35);
            this.lbWorkspace.TabIndex = 1;
            this.lbWorkspace.Text = "My Workspaces";
            // 
            // flpWorkspaces
            // 
            this.flpWorkspaces.Location = new System.Drawing.Point(36, 83);
            this.flpWorkspaces.Name = "flpWorkspaces";
            this.flpWorkspaces.Size = new System.Drawing.Size(800, 455);
            this.flpWorkspaces.TabIndex = 2;
            // 
            // FSetting_US_Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.flpWorkspaces);
            this.Controls.Add(this.lbWorkspace);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FSetting_US_Workspace";
            this.Size = new System.Drawing.Size(880, 586);
            this.Load += new System.EventHandler(this.FSetting_US_Workspace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWorkspace;
        private System.Windows.Forms.FlowLayoutPanel flpWorkspaces;
    }
}
