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
            this.btnMeeting = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnMeeting
            // 
            this.btnMeeting.BackColor = System.Drawing.Color.White;
            this.btnMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeeting.ForeColor = System.Drawing.Color.Black;
            this.btnMeeting.Location = new System.Drawing.Point(110, 12);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(78, 30);
            this.btnMeeting.TabIndex = 8;
            this.btnMeeting.Text = "Unread";
            this.btnMeeting.UseVisualStyleBackColor = false;
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.White;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.ForeColor = System.Drawing.Color.Black;
            this.btnTodo.Location = new System.Drawing.Point(26, 12);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(78, 30);
            this.btnTodo.TabIndex = 7;
            this.btnTodo.Text = "All";
            this.btnTodo.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.btnMeeting);
            this.Controls.Add(this.btnTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNotification";
            this.Text = "FNotification";
            this.Load += new System.EventHandler(this.FNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
    }
}