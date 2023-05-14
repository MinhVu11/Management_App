namespace ManageProjectApp
{
    partial class FormCreateNewSpace1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreateNewSpace
            // 
            this.labelCreateNewSpace.AutoSize = true;
            this.labelCreateNewSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewSpace.Location = new System.Drawing.Point(229, 84);
            this.labelCreateNewSpace.Name = "labelCreateNewSpace";
            this.labelCreateNewSpace.Size = new System.Drawing.Size(360, 51);
            this.labelCreateNewSpace.TabIndex = 0;
            this.labelCreateNewSpace.Text = "CreateNewSpace";
            // 
            // labelSpaceName
            // 
            this.labelSpaceName.AutoSize = true;
            this.labelSpaceName.Location = new System.Drawing.Point(75, 239);
            this.labelSpaceName.Name = "labelSpaceName";
            this.labelSpaceName.Size = new System.Drawing.Size(135, 25);
            this.labelSpaceName.TabIndex = 1;
            this.labelSpaceName.Text = "Space Name";           
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 38);
            this.textBox1.TabIndex = 2;
            // 
            // buttonNext1
            // 
            this.buttonNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext1.Location = new System.Drawing.Point(80, 360);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(650, 45);
            this.buttonNext1.TabIndex = 3;
            this.buttonNext1.Text = "Next";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // FormCreateNewSpace1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSpaceName);
            this.Controls.Add(this.labelCreateNewSpace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateNewSpace1";
            this.Text = "Creata New Space";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateNewSpace;
        private System.Windows.Forms.Label labelSpaceName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNext1;
    }
}