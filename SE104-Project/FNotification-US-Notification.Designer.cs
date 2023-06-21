namespace SE104_Project
{
    partial class FNotification_US_Notification
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbCreateAt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(24, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(327, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Enabled = false;
            this.tbDescription.ForeColor = System.Drawing.Color.Black;
            this.tbDescription.Location = new System.Drawing.Point(28, 50);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(339, 15);
            this.tbDescription.TabIndex = 1;
            // 
            // lbCreateAt
            // 
            this.lbCreateAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAt.ForeColor = System.Drawing.Color.Black;
            this.lbCreateAt.Location = new System.Drawing.Point(544, 50);
            this.lbCreateAt.Name = "lbCreateAt";
            this.lbCreateAt.Size = new System.Drawing.Size(138, 23);
            this.lbCreateAt.TabIndex = 2;
            this.lbCreateAt.Text = "label2";
            // 
            // FNotification_US_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbCreateAt);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FNotification_US_Notification";
            this.Size = new System.Drawing.Size(695, 85);
            this.Load += new System.EventHandler(this.FNotification_US_Notification_Load);
            this.Click += new System.EventHandler(this.FNotification_US_Notification_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbCreateAt;
    }
}
