namespace SE104_Project
{
    partial class FHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHome));
            this.pnCalendar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpCalendar = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbDay = new System.Windows.Forms.Label();
            this.pnMyWork = new System.Windows.Forms.Panel();
            this.lbMywork = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnMeeting = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShared = new System.Windows.Forms.Button();
            this.pnCalendar.SuspendLayout();
            this.pnMyWork.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCalendar
            // 
            this.pnCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCalendar.Controls.Add(this.monthCalendar);
            this.pnCalendar.Controls.Add(this.flpCalendar);
            this.pnCalendar.Controls.Add(this.label1);
            this.pnCalendar.Controls.Add(this.btnPrevious);
            this.pnCalendar.Controls.Add(this.btnNext);
            this.pnCalendar.Controls.Add(this.lbDay);
            this.pnCalendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnCalendar.Location = new System.Drawing.Point(515, 0);
            this.pnCalendar.Name = "pnCalendar";
            this.pnCalendar.Size = new System.Drawing.Size(386, 556);
            this.pnCalendar.TabIndex = 0;
            this.pnCalendar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCalendar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calendar";
            // 
            // flpCalendar
            // 
            this.flpCalendar.AutoScroll = true;
            this.flpCalendar.Location = new System.Drawing.Point(18, 65);
            this.flpCalendar.Name = "flpCalendar";
            this.flpCalendar.Size = new System.Drawing.Size(356, 484);
            this.flpCalendar.TabIndex = 3;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 71);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // lbDay
            // 
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.Black;
            this.lbDay.Location = new System.Drawing.Point(14, 39);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(269, 23);
            this.lbDay.TabIndex = 2;
            this.lbDay.Text = "label1";
            this.lbDay.Click += new System.EventHandler(this.lbDay_Click);
            // 
            // pnMyWork
            // 
            this.pnMyWork.Controls.Add(this.btnShared);
            this.pnMyWork.Controls.Add(this.btnMeeting);
            this.pnMyWork.Controls.Add(this.btnTodo);
            this.pnMyWork.Controls.Add(this.panel1);
            this.pnMyWork.Controls.Add(this.lbMywork);
            this.pnMyWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMyWork.Location = new System.Drawing.Point(0, 0);
            this.pnMyWork.Name = "pnMyWork";
            this.pnMyWork.Size = new System.Drawing.Size(515, 556);
            this.pnMyWork.TabIndex = 1;
            // 
            // lbMywork
            // 
            this.lbMywork.AutoSize = true;
            this.lbMywork.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMywork.ForeColor = System.Drawing.Color.Black;
            this.lbMywork.Location = new System.Drawing.Point(12, 9);
            this.lbMywork.Name = "lbMywork";
            this.lbMywork.Size = new System.Drawing.Size(107, 25);
            this.lbMywork.TabIndex = 2;
            this.lbMywork.Text = "My Work";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 474);
            this.panel1.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(497, 474);
            this.dgv.TabIndex = 4;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnTodo
            // 
            this.btnTodo.BackColor = System.Drawing.Color.White;
            this.btnTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodo.ForeColor = System.Drawing.Color.Black;
            this.btnTodo.Location = new System.Drawing.Point(12, 40);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(78, 30);
            this.btnTodo.TabIndex = 4;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = false;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnMeeting
            // 
            this.btnMeeting.BackColor = System.Drawing.Color.White;
            this.btnMeeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeeting.ForeColor = System.Drawing.Color.Black;
            this.btnMeeting.Location = new System.Drawing.Point(96, 40);
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.Size = new System.Drawing.Size(78, 30);
            this.btnMeeting.TabIndex = 5;
            this.btnMeeting.Text = "Meeting";
            this.btnMeeting.UseVisualStyleBackColor = false;
            this.btnMeeting.Click += new System.EventHandler(this.btnMeeting_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::SE104_Project.Properties.Resources.previous;
            this.btnPrevious.Location = new System.Drawing.Point(300, 39);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(25, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(331, 39);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShared
            // 
            this.btnShared.BackColor = System.Drawing.Color.White;
            this.btnShared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShared.ForeColor = System.Drawing.Color.Black;
            this.btnShared.Location = new System.Drawing.Point(180, 40);
            this.btnShared.Name = "btnShared";
            this.btnShared.Size = new System.Drawing.Size(78, 30);
            this.btnShared.TabIndex = 6;
            this.btnShared.Text = "Shared";
            this.btnShared.UseVisualStyleBackColor = false;
            this.btnShared.Click += new System.EventHandler(this.btnShared_Click);
            // 
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 556);
            this.Controls.Add(this.pnMyWork);
            this.Controls.Add(this.pnCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHome";
            this.Text = "FHome";
            this.Load += new System.EventHandler(this.FHome_Load);
            this.pnCalendar.ResumeLayout(false);
            this.pnCalendar.PerformLayout();
            this.pnMyWork.ResumeLayout(false);
            this.pnMyWork.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCalendar;
        private System.Windows.Forms.Panel pnMyWork;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lbMywork;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.FlowLayoutPanel flpCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMeeting;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnShared;
    }
}