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
            this.components = new System.ComponentModel.Container();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.tbWorkspaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateWS = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSignUp.Location = new System.Drawing.Point(203, 26);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(139, 32);
            this.lbSignUp.TabIndex = 3;
            this.lbSignUp.Text = "Welcome";
            // 
            // tbWorkspaceName
            // 
            this.tbWorkspaceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWorkspaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWorkspaceName.Location = new System.Drawing.Point(110, 137);
            this.tbWorkspaceName.Name = "tbWorkspaceName";
            this.tbWorkspaceName.Size = new System.Drawing.Size(370, 26);
            this.tbWorkspaceName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(106, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your Workspace name:";
            // 
            // btnCreateWS
            // 
            this.btnCreateWS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateWS.FlatAppearance.BorderSize = 2;
            this.btnCreateWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWS.ForeColor = System.Drawing.Color.White;
            this.btnCreateWS.Location = new System.Drawing.Point(110, 199);
            this.btnCreateWS.Name = "btnCreateWS";
            this.btnCreateWS.Size = new System.Drawing.Size(370, 42);
            this.btnCreateWS.TabIndex = 8;
            this.btnCreateWS.Text = "Create";
            this.btnCreateWS.UseVisualStyleBackColor = true;
            this.btnCreateWS.Click += new System.EventHandler(this.btnCreateWS_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FCreateWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(657, 329);
            this.Controls.Add(this.btnCreateWS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWorkspaceName);
            this.Controls.Add(this.lbSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCreateWorkspace";
            this.Text = "FCreateWorkspace";
            this.Load += new System.EventHandler(this.FCreateWorkspace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.TextBox tbWorkspaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateWS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}