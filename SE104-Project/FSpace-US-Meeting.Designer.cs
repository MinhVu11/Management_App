namespace SE104_Project
{
    partial class FSpace_US_Meeting
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
            this.flpAgenda = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpAgenda
            // 
            this.flpAgenda.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAgenda.Location = new System.Drawing.Point(131, 0);
            this.flpAgenda.Name = "flpAgenda";
            this.flpAgenda.Size = new System.Drawing.Size(625, 501);
            this.flpAgenda.TabIndex = 0;
            // 
            // FSpace_US_Meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpAgenda);
            this.Name = "FSpace_US_Meeting";
            this.Size = new System.Drawing.Size(901, 501);
            this.Load += new System.EventHandler(this.FSpace_US_Meeting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAgenda;
    }
}
