namespace SE104_Project
{
    partial class FMoveAgenda
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
            this.cBIn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBIn
            // 
            this.cBIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBIn.FormattingEnabled = true;
            this.cBIn.Location = new System.Drawing.Point(111, 27);
            this.cBIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cBIn.Name = "cBIn";
            this.cBIn.Size = new System.Drawing.Size(232, 26);
            this.cBIn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose space";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(253, 74);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(90, 35);
            this.btnMove.TabIndex = 11;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // FMoveAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 131);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBIn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMoveAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FMoveAgenda";
            this.Load += new System.EventHandler(this.FMoveAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMove;
    }
}