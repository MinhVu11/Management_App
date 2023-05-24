namespace SE104_Project
{
    partial class FCreateWorkspace
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
            this.tbWorkspaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateWS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSignUp.Location = new System.Drawing.Point(304, 41);
            this.lbSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(216, 52);
            this.lbSignUp.TabIndex = 3;
            this.lbSignUp.Text = "Welcome";
            // 
            // tbWorkspaceName
            // 
            this.tbWorkspaceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWorkspaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWorkspaceName.Location = new System.Drawing.Point(165, 214);
            this.tbWorkspaceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWorkspaceName.Name = "tbWorkspaceName";
            this.tbWorkspaceName.Size = new System.Drawing.Size(554, 38);
            this.tbWorkspaceName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(159, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Workspace name:";
            // 
            // btnCreateWS
            // 
            this.btnCreateWS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateWS.FlatAppearance.BorderSize = 2;
            this.btnCreateWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWS.ForeColor = System.Drawing.Color.White;
            this.btnCreateWS.Location = new System.Drawing.Point(165, 311);
            this.btnCreateWS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateWS.Name = "btnCreateWS";
            this.btnCreateWS.Size = new System.Drawing.Size(555, 66);
            this.btnCreateWS.TabIndex = 8;
            this.btnCreateWS.Text = "Create";
            this.btnCreateWS.UseVisualStyleBackColor = true;
            this.btnCreateWS.Click += new System.EventHandler(this.btnCreateWS_Click);
            // 
            // FCreateWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(986, 514);
            this.Controls.Add(this.btnCreateWS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWorkspaceName);
            this.Controls.Add(this.lbSignUp);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FCreateWorkspace";
            this.Text = "FCreateWorkspace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.TextBox tbWorkspaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateWS;
    }
}