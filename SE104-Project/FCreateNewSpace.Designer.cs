namespace SE104_Project
{
    partial class FCreateNewSpace
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCreateSpace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpaceName = new System.Windows.Forms.TextBox();
            this.btnCreateSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // labelCreateSpace
            // 
            this.labelCreateSpace.AutoSize = true;
            this.labelCreateSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateSpace.Location = new System.Drawing.Point(209, 69);
            this.labelCreateSpace.Name = "labelCreateSpace";
            this.labelCreateSpace.Size = new System.Drawing.Size(398, 51);
            this.labelCreateSpace.TabIndex = 1;
            this.labelCreateSpace.Text = "Create New Space";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = " Space Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSpaceName
            // 
            this.tbSpaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpaceName.Location = new System.Drawing.Point(107, 243);
            this.tbSpaceName.Name = "tbSpaceName";
            this.tbSpaceName.Size = new System.Drawing.Size(594, 35);
            this.tbSpaceName.TabIndex = 3;
            // 
            // btnCreateSpace
            // 
            this.btnCreateSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSpace.Location = new System.Drawing.Point(107, 343);
            this.btnCreateSpace.Name = "btnCreateSpace";
            this.btnCreateSpace.Size = new System.Drawing.Size(594, 67);
            this.btnCreateSpace.TabIndex = 5;
            this.btnCreateSpace.Text = " Create Space";
            this.btnCreateSpace.UseVisualStyleBackColor = false;
            this.btnCreateSpace.Click += new System.EventHandler(this.btnCreateSpace_Click);
            // 
            // FCreateNewSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateSpace);
            this.Controls.Add(this.tbSpaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCreateSpace);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FCreateNewSpace";
            this.Text = "Create New Space";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCreateSpace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpaceName;
        private System.Windows.Forms.Button btnCreateSpace;
    }
}