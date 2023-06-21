using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FEditTask : Form
    {
        private int taskid;
        private Dictionary<Label, string> fileLabels = new Dictionary<Label, string>();
        public FEditTask(int taskid)
        {
            InitializeComponent();
            this.taskid = taskid;
        }

        private void FEditTask_Load(object sender, EventArgs e)
        {
            DataTable taskdata = SQLHandler.Instance.GetData($"SElect * from task where task_id={taskid}");
            DateTime datestart = (DateTime)taskdata.Rows[0]["Task_start_time"];
            lbStartDate.Text = "Created " + datestart.ToString("MMM d, HH:mm");
            tbTaskName.Text = taskdata.Rows[0]["Task_name"].ToString().Trim();
            rTBTaskDescription.Text = taskdata.Rows[0]["Task_description"].ToString().Trim();
            cBStatus.SelectedItem = $"{taskdata.Rows[0]["Task_status"].ToString().Trim()}";
            DataTable moveto = SQLHandler.Instance.GetData($"Select * from Space,Workspace_Space where Workspace_Space.space_id=space.Space_id and Workspace_Space.workspace_id={FWorkspace.Workspace_id}");
            cbMoveto.DataSource = moveto;

            cbMoveto.DisplayMember = "Space_name";
            DataTable where = SQLHandler.Instance.GetData($"Select space.* from space,task_space where task_space.space_id=space.space_id and task_space.task_id={taskid}");
            if (where.Rows.Count > 0)
            {
                string selectedSpaceName = where.Rows[0]["Space_name"].ToString().Trim();
                int selectedIndex = cbMoveto.FindString(selectedSpaceName);
                cbMoveto.SelectedIndex = selectedIndex;

            }


            DataTable assignment = SQLHandler.Instance.GetData($"Select Users.* from users,assignment where users.user_id=assignment.user_id and assignment.task_id={taskid}");
            lBPeopleList.DataSource = assignment;
            lBPeopleList.DisplayMember = "User_name";

            // Lấy danh sách tệp tin đính kèm từ SQL Server
            DataTable attachmentData = SQLHandler.Instance.GetData($"SELECT FileName, FileData FROM TaskAttachments WHERE Task_id = {taskid}");

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
                // Thêm thông tin về label và đường dẫn tệp tin vào Dictionary
                
            }
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            FShareTask f = new FShareTask(taskid);
            f.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbTaskName.Text == "")
            {
                MessageBox.Show("Please enter Your Task Name");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Update Task set task_name='{tbTaskName.Text}',task_description= '{rTBTaskDescription.Text}', task_status='{cBStatus.Text}',task_end_time= '{dTPEndDate.Value}' where task_id={taskid} ");

                SQLHandler.Instance.ExcuteNonQuery($"Delete from task_space where task_id={taskid}");
                DataRowView cbmoveto = (DataRowView)cbMoveto.SelectedValue;
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task_Space(Task_id, Space_id) values ({taskid},{cbmoveto["Space_id"]})");

                SQLHandler.Instance.ExcuteNonQuery($"Delete from Assignment where task_id={taskid}");
                foreach (object item in lBPeopleList.Items)
                {
                    DataRowView row = (DataRowView)item;

                    int id = Convert.ToInt32(row["user_id"]);
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Assignment( Task_id, User_id) values ({taskid},{id})");

                }
                // Chèn thông tin tệp tin đính kèm vào bảng "TaskAttachment"
                foreach (var fileLabel in fileLabels)
                {
                    string fileName = fileLabel.Key.Text;
                    string filePath = fileLabel.Value;

                    byte[] fileData = File.ReadAllBytes(filePath);

                    // Chèn thông tin tệp tin đính kèm vào bảng "TaskAttachment"
                    string query = "INSERT INTO TaskAttachments (Task_id, FileName, FileData) VALUES (@TaskId, @FileName, @FileData)";
                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@TaskId", taskid),
                        new SqlParameter("@FileName", fileName),
                        new SqlParameter("@FileData", fileData)
                    };

                    SQLHandler.Instance.ExecuteNonQueryWithParameters(query, parameters);
                }

                Close();
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
    }
}
