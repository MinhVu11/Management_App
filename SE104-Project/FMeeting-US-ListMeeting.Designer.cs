namespace SE104_Project
{
    partial class FMeeting_US_ListMeeting
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
            this.tvListMeeting = new System.Windows.Forms.TreeView();
            this.pnMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tvListMeeting
            // 
            this.tvListMeeting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvListMeeting.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvListMeeting.ForeColor = System.Drawing.Color.Black;
            this.tvListMeeting.Location = new System.Drawing.Point(0, 0);
            this.tvListMeeting.Name = "tvListMeeting";
            this.tvListMeeting.Size = new System.Drawing.Size(236, 501);
            this.tvListMeeting.TabIndex = 0;
            this.tvListMeeting.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvListMeeting_NodeMouseDoubleClick);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(236, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(665, 501);
            this.pnMain.TabIndex = 1;
            // 
            // FMeeting_US_ListMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.tvListMeeting);
            this.Name = "FMeeting_US_ListMeeting";
            this.Size = new System.Drawing.Size(901, 501);
            this.Load += new System.EventHandler(this.FMeeting_US_ListMeeting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvListMeeting;
        private System.Windows.Forms.Panel pnMain;
    }
}
