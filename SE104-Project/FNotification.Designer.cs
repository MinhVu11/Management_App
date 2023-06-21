namespace SE104_Project
{
    partial class FNotification
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
            this.btnUnread = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnUnread
            // 
            this.btnUnread.BackColor = System.Drawing.Color.White;
            this.btnUnread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnread.ForeColor = System.Drawing.Color.Black;
            this.btnUnread.Location = new System.Drawing.Point(110, 12);
            this.btnUnread.Name = "btnUnread";
            this.btnUnread.Size = new System.Drawing.Size(78, 30);
            this.btnUnread.TabIndex = 8;
            this.btnUnread.Text = "UnRead";
            this.btnUnread.UseVisualStyleBackColor = false;
            this.btnUnread.Click += new System.EventHandler(this.btnUnread_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Location = new System.Drawing.Point(26, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(78, 30);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // flpNotification
            // 
            this.flpNotification.AutoScroll = true;
            this.flpNotification.Location = new System.Drawing.Point(96, 59);
            this.flpNotification.Name = "flpNotification";
            this.flpNotification.Size = new System.Drawing.Size(700, 395);
            this.flpNotification.TabIndex = 10;
            // 
            // FNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 556);
            this.Controls.Add(this.flpNotification);
            this.Controls.Add(this.btnUnread);
            this.Controls.Add(this.btnAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNotification";
            this.Text = "FNotification";
            this.Load += new System.EventHandler(this.FNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnread;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
    }
}