namespace SE104_Project
{
    partial class FCreateMeeting
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRequired = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbOrganizer = new System.Windows.Forms.TextBox();
            this.tbRequired = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dtpStarttime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDesciption = new System.Windows.Forms.TextBox();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.dtpEndtime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Image = global::SE104_Project.Properties.Resources.send;
            this.btnSend.Location = new System.Drawing.Point(12, 27);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 67);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(93, 27);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(85, 34);
            this.btnFrom.TabIndex = 1;
            this.btnFrom.Text = "From";
            this.btnFrom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(90, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRequired
            // 
            this.btnRequired.Location = new System.Drawing.Point(90, 99);
            this.btnRequired.Name = "btnRequired";
            this.btnRequired.Size = new System.Drawing.Size(85, 34);
            this.btnRequired.TabIndex = 3;
            this.btnRequired.Text = "Required";
            this.btnRequired.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(90, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(93, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "End time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(87, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(203, 74);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(617, 20);
            this.tbTitle.TabIndex = 8;
            // 
            // tbOrganizer
            // 
            this.tbOrganizer.BackColor = System.Drawing.SystemColors.Control;
            this.tbOrganizer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrganizer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbOrganizer.Location = new System.Drawing.Point(203, 27);
            this.tbOrganizer.Name = "tbOrganizer";
            this.tbOrganizer.ReadOnly = true;
            this.tbOrganizer.Size = new System.Drawing.Size(617, 20);
            this.tbOrganizer.TabIndex = 9;
            // 
            // tbRequired
            // 
            this.tbRequired.BackColor = System.Drawing.SystemColors.Control;
            this.tbRequired.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequired.Location = new System.Drawing.Point(203, 111);
            this.tbRequired.Name = "tbRequired";
            this.tbRequired.Size = new System.Drawing.Size(617, 20);
            this.tbRequired.TabIndex = 10;
            this.tbRequired.TextChanged += new System.EventHandler(this.tbRequired_TextChanged);
            this.tbRequired.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRequired_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(203, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(617, 20);
            this.textBox5.TabIndex = 12;
            // 
            // dtpStarttime
            // 
            this.dtpStarttime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStarttime.CustomFormat = "ddd dd/MM/yyyy ";
            this.dtpStarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStarttime.Location = new System.Drawing.Point(203, 159);
            this.dtpStarttime.Name = "dtpStarttime";
            this.dtpStarttime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpStarttime.Size = new System.Drawing.Size(159, 22);
            this.dtpStarttime.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDesciption);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 182);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // tbDesciption
            // 
            this.tbDesciption.BackColor = System.Drawing.SystemColors.Control;
            this.tbDesciption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDesciption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDesciption.Location = new System.Drawing.Point(3, 18);
            this.tbDesciption.Multiline = true;
            this.tbDesciption.Name = "tbDesciption";
            this.tbDesciption.Size = new System.Drawing.Size(855, 161);
            this.tbDesciption.TabIndex = 0;
            // 
            // cbStart
            // 
            this.cbStart.DropDownHeight = 80;
            this.cbStart.FormattingEnabled = true;
            this.cbStart.IntegralHeight = false;
            this.cbStart.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cbStart.Location = new System.Drawing.Point(368, 156);
            this.cbStart.MaxDropDownItems = 5;
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(120, 24);
            this.cbStart.TabIndex = 16;
            // 
            // dtpEndtime
            // 
            this.dtpEndtime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndtime.CustomFormat = "ddd dd/MM/yyyy ";
            this.dtpEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndtime.Location = new System.Drawing.Point(203, 190);
            this.dtpEndtime.Name = "dtpEndtime";
            this.dtpEndtime.Size = new System.Drawing.Size(159, 22);
            this.dtpEndtime.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(203, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 1);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(203, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 1);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(203, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 1);
            this.panel3.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Location = new System.Drawing.Point(203, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(617, 1);
            this.panel5.TabIndex = 23;
            // 
            // cbEnd
            // 
            this.cbEnd.DropDownHeight = 80;
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.IntegralHeight = false;
            this.cbEnd.Items.AddRange(new object[] {
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00",
            "2:30",
            "3:00",
            "3:30",
            "4:00",
            "4:30",
            "5:00",
            "5:30",
            "6:00",
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cbEnd.Location = new System.Drawing.Point(368, 190);
            this.cbEnd.MaxDropDownItems = 5;
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(120, 24);
            this.cbEnd.TabIndex = 24;
            // 
            // FCreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpEndtime);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpStarttime);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbRequired);
            this.Controls.Add(this.tbOrganizer);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRequired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCreateMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FCreateMeeting";
            this.Load += new System.EventHandler(this.FCreateMeeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbOrganizer;
        private System.Windows.Forms.TextBox tbRequired;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dtpStarttime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDesciption;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.DateTimePicker dtpEndtime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbEnd;
    }
}