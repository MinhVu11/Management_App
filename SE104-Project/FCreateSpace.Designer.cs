namespace ManageProjectApp
{
    partial class FCreateSpace
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
            this.labelCreateNewSpace = new System.Windows.Forms.Label();
            this.labelSpaceName = new System.Windows.Forms.Label();
            this.tbSpaceName = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCreateNewSpace
            // 
            this.labelCreateNewSpace.AutoSize = true;
            this.labelCreateNewSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewSpace.ForeColor = System.Drawing.Color.White;
            this.labelCreateNewSpace.Location = new System.Drawing.Point(153, 54);
            this.labelCreateNewSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateNewSpace.Name = "labelCreateNewSpace";
            this.labelCreateNewSpace.Size = new System.Drawing.Size(228, 31);
            this.labelCreateNewSpace.TabIndex = 0;
            this.labelCreateNewSpace.Text = "CreateNewSpace";
            // 
            // labelSpaceName
            // 
            this.labelSpaceName.AutoSize = true;
            this.labelSpaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpaceName.ForeColor = System.Drawing.Color.White;
            this.labelSpaceName.Location = new System.Drawing.Point(49, 149);
            this.labelSpaceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpaceName.Name = "labelSpaceName";
            this.labelSpaceName.Size = new System.Drawing.Size(105, 20);
            this.labelSpaceName.TabIndex = 1;
            this.labelSpaceName.Text = "Space Name";
            // 
            // tbSpaceName
            // 
            this.tbSpaceName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbSpaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpaceName.Location = new System.Drawing.Point(53, 171);
            this.tbSpaceName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpaceName.Name = "tbSpaceName";
            this.tbSpaceName.Size = new System.Drawing.Size(309, 27);
            this.tbSpaceName.TabIndex = 2;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(53, 230);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(452, 29);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbbType.Location = new System.Drawing.Point(384, 171);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(121, 24);
            this.cbbType.TabIndex = 4;
            // 
            // FCreateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(533, 288);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.tbSpaceName);
            this.Controls.Add(this.labelSpaceName);
            this.Controls.Add(this.labelCreateNewSpace);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCreateSpace";
            this.Text = "Creata New Space";
            this.Load += new System.EventHandler(this.FCreateSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateNewSpace;
        private System.Windows.Forms.Label labelSpaceName;
        private System.Windows.Forms.TextBox tbSpaceName;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ComboBox cbbType;
    }
}