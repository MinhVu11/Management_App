using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_Agenda : UserControl
    {
        int meeting_id;
        public US_Agenda(int meeting_id)
        {
            InitializeComponent();
            this.meeting_id = meeting_id;   
        }

        private void US_Agenda_Load(object sender, EventArgs e)
        {
            DataTable meetingdata = SQLHandler.Instance.GetData($"Select * from Meeting where Meeting_id={meeting_id}");
            lbName.Text = meetingdata.Rows[0]["Meeting_name"].ToString().Trim();
            lbCreateAt.Text ="Create at " +meetingdata.Rows[0]["Meeting_start_time"].ToString().Trim();
            // Lấy danh sách tệp tin đính kèm từ SQL Server
            DataTable attachmentData = SQLHandler.Instance.GetData($"SELECT FileName, FileData FROM MeetingAttachments WHERE Meeting_id = {meeting_id}");

            foreach (DataRow row in attachmentData.Rows)
            {
                string fileName = row["FileName"].ToString();
                byte[] fileData = (byte[])row["FileData"];

                // Tạo và cấu hình label mới
                Label lblFileName = new Label();
                lblFileName.Text = fileName;
                lblFileName.ForeColor = Color.Blue;
                lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);
                lblFileName.Cursor = Cursors.Hand;
                lblFileName.Click += lblFileName_Click;
                lblFileName.Tag = fileData; // Attach the file data as a tag to the label

                // Thêm label vào FlowLayoutPanel
                flpFileName.Controls.Add(lblFileName);
            }

        }
        private string GetMimeType(string fileExtension)
        {
            if (string.IsNullOrEmpty(fileExtension))
                return string.Empty;

            string extension = fileExtension.ToLower();

            switch (extension)
            {
                case ".txt":
                    return "text/plain";
                case ".doc":
                case ".docx":
                    return "application/msword";
                case ".xls":
                case ".xlsx":
                    return "application/vnd.ms-excel";
                case ".ppt":
                case ".pptx":
                    return "application/vnd.ms-powerpoint";
                case ".pdf":
                    return "application/pdf";
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".gif":
                    return "image/gif";
                // Thêm các phần mở rộng khác và loại tệp tin tương ứng vào đây
                default:
                    return "application/octet-stream";
            }
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            Label lblClicked = (Label)sender;
            byte[] fileData = (byte[])lblClicked.Tag; // Retrieve the file data from the label's tag

            // Lấy thông tin về loại tệp tin
            string fileExtension = Path.GetExtension(lblClicked.Text);
            string fileType = GetMimeType(fileExtension);

            // Xác định tên tệp tin khi lưu
            string fileName = lblClicked.Text;

            // Xử lý tải xuống tệp tin với loại tệp tin đúng
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = $"{fileType} Files|*{fileExtension}";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                File.WriteAllBytes(savePath, fileData);
                MessageBox.Show("File downloaded successfully.");
            }
        }

        private void US_Agenda_Click(object sender, EventArgs e)
        {
            US_EditMeeting us = new US_EditMeeting(meeting_id);
            Form f = new Form();
            f.Controls.Add(us);
            f.AutoSize = true;
            us.Dock = DockStyle.Fill;
            f.ShowDialog();
        }
    }
}
