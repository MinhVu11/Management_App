namespace SE104_Project
{
    partial class US_Hour
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
            this.lbHour = new System.Windows.Forms.Label();
            this.flpEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.ForeColor = System.Drawing.Color.Black;
            this.lbHour.Location = new System.Drawing.Point(3, 14);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(44, 16);
            this.lbHour.TabIndex = 0;
            this.lbHour.Text = "label1";
            this.lbHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpEvents
            // 
            this.flpEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEvents.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpEvents.Location = new System.Drawing.Point(50, 0);
            this.flpEvents.Name = "flpEvents";
            this.flpEvents.Size = new System.Drawing.Size(270, 50);
            this.flpEvents.TabIndex = 1;
            // 
            // US_Hour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpEvents);
            this.Controls.Add(this.lbHour);
            this.Name = "US_Hour";
            this.Size = new System.Drawing.Size(320, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.FlowLayoutPanel flpEvents;
    }
}
