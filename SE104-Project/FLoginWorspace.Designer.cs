namespace SE104_Project
{
    partial class FLoginWorspace
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
            this.lbSignUp = new System.Windows.Forms.Label();
            this.flpWorkspaces = new System.Windows.Forms.FlowLayoutPanel();
            this.llbCreateNewWS = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSignUp.Location = new System.Drawing.Point(293, 9);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(144, 33);
            this.lbSignUp.TabIndex = 2;
            this.lbSignUp.Text = "Welcome";
            // 
            // flpWorkspaces
            // 
            this.flpWorkspaces.Location = new System.Drawing.Point(76, 68);
            this.flpWorkspaces.Name = "flpWorkspaces";
            this.flpWorkspaces.Size = new System.Drawing.Size(609, 245);
            this.flpWorkspaces.TabIndex = 3;
            // 
            // llbCreateNewWS
            // 
            this.llbCreateNewWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbCreateNewWS.LinkColor = System.Drawing.Color.White;
            this.llbCreateNewWS.Location = new System.Drawing.Point(280, 367);
            this.llbCreateNewWS.Name = "llbCreateNewWS";
            this.llbCreateNewWS.Size = new System.Drawing.Size(205, 23);
            this.llbCreateNewWS.TabIndex = 7;
            this.llbCreateNewWS.TabStop = true;
            this.llbCreateNewWS.Text = "Create new workspace?";
            this.llbCreateNewWS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreateNewWS_LinkClicked);
            // 
            // FLoginWorspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbCreateNewWS);
            this.Controls.Add(this.flpWorkspaces);
            this.Controls.Add(this.lbSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLoginWorspace";
            this.Text = "LoginWorspace";
            this.Load += new System.EventHandler(this.FLoginWorspace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.FlowLayoutPanel flpWorkspaces;
        private System.Windows.Forms.LinkLabel llbCreateNewWS;
    }
}