namespace SE104_Project
{
    partial class US_Days
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
            this.lbDays = new System.Windows.Forms.Label();
            this.flpEvent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(34, 9);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(44, 16);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "label1";
            // 
            // flpEvent
            // 
            this.flpEvent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpEvent.Location = new System.Drawing.Point(0, 28);
            this.flpEvent.Name = "flpEvent";
            this.flpEvent.Size = new System.Drawing.Size(121, 34);
            this.flpEvent.TabIndex = 1;
            // 
            // US_Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpEvent);
            this.Controls.Add(this.lbDays);
            this.Name = "US_Days";
            this.Size = new System.Drawing.Size(121, 62);
            this.Load += new System.EventHandler(this.US_Days_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.FlowLayoutPanel flpEvent;
    }
}
