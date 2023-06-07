namespace SE104_Project
{
    partial class US_CreateTask
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTask.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateTask.Location = new System.Drawing.Point(0, 0);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(120, 64);
            this.btnCreateTask.TabIndex = 2;
            this.btnCreateTask.Text = "+ Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // US_CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateTask);
            this.Name = "US_CreateTask";
            this.Size = new System.Drawing.Size(120, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTask;
    }
}
