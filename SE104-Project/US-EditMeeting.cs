using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_EditMeeting : UserControl
    {
        private int meeting_id;
        private Dictionary<Label, string> fileLabels = new Dictionary<Label, string>();
        public US_EditMeeting(int id)
        {
            InitializeComponent();
            this.meeting_id = id;
        }

        private void FMeeting_US_Meeting_Load(object sender, EventArgs e)
        {

            DataTable meetingdata = SQLHandler.Instance.GetData($"Select * from Meeting where Meeting_id={meeting_id}");
            DataTable organizer = SQLHandler.Instance.GetData($"Select * from Users where User_id={Convert.ToInt32(meetingdata.Rows[0]["Organizer_id"])}");
            tbOrganizer.Text = organizer.Rows[0]["User_email"].ToString().Trim();
            tbTitle.Text = meetingdata.Rows[0]["meeting_name"].ToString().Trim();
            tbLocation.Text = meetingdata.Rows[0]["Meeting_location"].ToString().Trim();
            if (meetingdata.Rows[0]["Meeting_status"].ToString().Trim().ToLower() == "checked")
            {
                cbCheck.Checked = true;
            }
            else
            {
                cbCheck.Checked = false;
            }
            dtpStarttime.Value = ((DateTime)meetingdata.Rows[0]["Meeting_start_time"]).Date;
            cbStart.SelectedItem = $"{((DateTime)meetingdata.Rows[0]["Meeting_start_time"]).Hour}:{((DateTime)meetingdata.Rows[0]["Meeting_start_time"]).Minute.ToString("D2")}";
            dtpEndtime.Value = ((DateTime)meetingdata.Rows[0]["Meeting_end_time"]).Date;
            cbEnd.SelectedItem = $"{((DateTime)meetingdata.Rows[0]["Meeting_end_time"]).Hour}:{((DateTime)meetingdata.Rows[0]["Meeting_end_time"]).Minute.ToString("D2")}";
            tbDesciption.Text = meetingdata.Rows[0]["Meeting_description"].ToString().Trim();

            tbRequired.Text = "";
            DataTable participant = SQLHandler.Instance.GetData($"Select users.* from participants,users where meeting_id={meeting_id} and users.User_id=Participants.User_id");
            foreach (DataRow row in participant.Rows)
            {
                tbRequired.Text += row["User_email"].ToString().Trim() + ';';
            }
            DateTime dt = ((DateTime)meetingdata.Rows[0]["Meeting_end_time"]);
            if (dt < DateTime.Now && cbCheck.Checked == true)
            {
                btnAttachfile.Visible = true;
                btnMoveTo.Visible = true;
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                MessageBox.Show("Please enter tilte");
            }
            else
            {
                string check;
                if (cbCheck.Checked)
                {
                    check = "checked";
                }
                else
                {
                    check = "unchecked";
                }
                DateTime starttime = dtpStarttime.Value.Date.Add(TimeSpan.Parse(cbStart.SelectedItem.ToString()));
                DateTime endtime = dtpEndtime.Value.Date.Add(TimeSpan.Parse(cbEnd.SelectedItem.ToString()));
                SQLHandler.Instance.ExcuteNonQuery($"Update Meeting set Organizer_id={FWorkspace.User_id},Meeting_name='{tbTitle.Text}',Meeting_Start_time='{starttime}',Meeting_end_time='{endtime}',Meeting_description='{tbDesciption.Text}',Meeting_status='{check}' where Meeting_id={meeting_id}");
                DataTable meeting = SQLHandler.Instance.GetData("SELECT TOP 1 * FROM meeting ORDER BY Meeting_id DESC");

                SQLHandler.Instance.ExcuteNonQuery($"Delete from participants where Meeting_id={meeting.Rows[0]["Meeting_id"]}");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Participants values({meeting.Rows[0]["meeting_id"]},{meeting.Rows[0]["Organizer_id"]})");
                string[] strings = tbRequired.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in strings)
                {
                    DataTable participant = SQLHandler.Instance.GetData($"Select * from Users where User_email='{str}'");
                    if (Convert.ToInt32(meeting.Rows[0]["Organizer_id"]) != Convert.ToInt32(participant.Rows[0]["User_id"]))
                    {
                        SQLHandler.Instance.ExcuteNonQuery($"Insert into Participants values({meeting.Rows[0]["Meeting_id"]},{participant.Rows[0]["User_id"]})");

                    }
                }
                if ((DateTime)meeting.Rows[0]["Meeting_end_time"] < DateTime.Now)
                {
                    // Chèn thông tin tệp tin đính kèm vào bảng "MeetingAttachment"
                    foreach (var fileLabel in fileLabels)
                    {
                        string fileName = fileLabel.Key.Text;
                        string filePath = fileLabel.Value;

                        byte[] fileData = File.ReadAllBytes(filePath);


                        string query = "INSERT INTO MeetingAttachments (Meeting_id, FileName, FileData) VALUES (@MeetingId, @FileName, @FileData)";
                        List<SqlParameter> parameters = new List<SqlParameter>
                        {
                            new SqlParameter("@MeetingId", meeting_id),
                            new SqlParameter("@FileName", fileName),
                            new SqlParameter("@FileData", fileData)
                        };

                        SQLHandler.Instance.ExecuteNonQueryWithParameters(query, parameters);
                    }
                }

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

        private void btnAttachfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                // Tạo và cấu hình label mới
                Label lblFileName = new Label();
                lblFileName.Text = Path.GetFileName(selectedFilePath);
                lblFileName.ForeColor = Color.Blue;
                lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);
                lblFileName.Cursor = Cursors.Hand;
                lblFileName.Click += lblFileName_Click;

                // Thêm label vào FlowLayoutPanel
                flpFileName.Controls.Add(lblFileName);

                // Thêm thông tin về label và đường dẫn tệp tin vào Dictionary
                fileLabels.Add(lblFileName, selectedFilePath);
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            FMoveAgenda f = new FMoveAgenda(meeting_id);
            f.ShowDialog();
        }
    }
}
