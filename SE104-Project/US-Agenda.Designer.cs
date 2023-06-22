namespace SE104_Project
{
    partial class US_Agenda
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
            this.lbCreateAt = new System.Windows.Forms.Label();
            this.flpFileName = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.Control;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(17, 15);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 22);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // lbCreateAt
            // 
            this.lbCreateAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAt.ForeColor = System.Drawing.Color.Black;
            this.lbCreateAt.Location = new System.Drawing.Point(17, 64);
            this.lbCreateAt.Name = "lbCreateAt";
            this.lbCreateAt.Size = new System.Drawing.Size(138, 23);
            this.lbCreateAt.TabIndex = 5;
            this.lbCreateAt.Text = "label2";
            // 
            // flpFileName
            // 
            this.flpFileName.AutoScroll = true;
            this.flpFileName.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpFileName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFileName.ForeColor = System.Drawing.Color.Black;
            this.flpFileName.Location = new System.Drawing.Point(383, 0);
            this.flpFileName.Name = "flpFileName";
            this.flpFileName.Size = new System.Drawing.Size(237, 98);
            this.flpFileName.TabIndex = 49;
            // 
            // US_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpFileName);
            this.Controls.Add(this.lbCreateAt);
            this.Controls.Add(this.lbName);
            this.Name = "US_Agenda";
            this.Size = new System.Drawing.Size(620, 98);
            this.Load += new System.EventHandler(this.US_Agenda_Load);
            this.Click += new System.EventHandler(this.US_Agenda_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCreateAt;
        private System.Windows.Forms.FlowLayoutPanel flpFileName;
    }
}
