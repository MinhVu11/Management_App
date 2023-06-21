using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FCreateTask : Form
    {
        private int highlightedIndex = -1; // Lưu chỉ số của mục đang được trỏ vào
        private int chosen_User;
        private Dictionary<int, string> userDictionary = new Dictionary<int, string>();

        private Dictionary<Label, string> fileLabels = new Dictionary<Label, string>();


        public FCreateTask()
        {
            InitializeComponent();
            lBPeopleList.DrawMode = DrawMode.OwnerDrawFixed;
            Load();
        }

        private void Load()
        {
            // Load comboBox Danh sach Space

            DataTable Spaces_data = SQLHandler.Instance.GetData($"select Space.* from Space, Workspace_Space where Space.Space_id = Workspace_Space.Space_id and Workspace_Space.Workspace_id = {FWorkspace.Workspace_id} ");
            cBIn.DataSource = Spaces_data;
            cBIn.DisplayMember = "Space_name";
            cBIn.ValueMember = "Space_id";



        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if (tbTaskName.Text == "")
            {
                MessageBox.Show("Please enter Your Task Name");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task(Task_name, Task_description, Task_status, Task_start_time, Task_end_time) values('{tbTaskName.Text}', '{rTBTaskDescription.Text}', '{cBStatus.Text}', '{dTPStartDate.Value}', '{dTPEndDate.Value}' ) ");

                DataTable Task_data = SQLHandler.Instance.GetData($"select TOP 1 * from Task Order by Task_id DESC");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task_Space(Task_id, Space_id) values ({Task_data.Rows[0]["Task_id"]},{cBIn.SelectedValue})");

                foreach (object item in lBPeopleList.Items)
                {
                    // get userid from dictionary
                    int id = userDictionary.FirstOrDefault(x => x.Value == item.ToString()).Key;
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Assignment( Task_id, User_id) values ({Convert.ToInt32(Task_data.Rows[0]["Task_id"])},{id})");
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
                        new SqlParameter("@TaskId", Convert.ToInt32(Task_data.Rows[0]["Task_id"])),
                        new SqlParameter("@FileName", fileName),
                        new SqlParameter("@FileData", fileData)
                    };

                    SQLHandler.Instance.ExecuteNonQueryWithParameters(query, parameters);
                }



                Close();
            }
        }

        private void cBAddPeople_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cBAddPeople.SelectedItem;
            DataTable Chosen_User = SQLHandler.Instance.GetData($"Select * from Users where Users.USer_id = {selectedRow["User_id"]}");

            if (Chosen_User.Rows.Count > 0)
            {

                if (lBPeopleList.Items.Contains(Chosen_User.Rows[0]["User_name"].ToString().Trim()))
                {
                    MessageBox.Show("User has been added");
                }
                else
                {
                    userDictionary.Add(Convert.ToInt32(Chosen_User.Rows[0]["User_id"]), Chosen_User.Rows[0]["User_name"].ToString().Trim());
                    lBPeopleList.Items.Add(Chosen_User.Rows[0]["User_name"].ToString().Trim());
                }
            }

        }

        private void cBIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBIn.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cBIn.SelectedItem;
                int selectedSpaceId = Convert.ToInt32(selectedRow["Space_id"]);
                DataTable spacemember = new DataTable();

                if (selectedRow["Space_type"].ToString().Trim() == "public")
                {
                    spacemember = SQLHandler.Instance.GetData($"Select Users.* from Users, Membership where Users.User_id=Membership.User_id and Membership.Workspace_id={FWorkspace.Workspace_id}");
                }
                else if (selectedRow["Space_type"].ToString().Trim() == "private")
                {
                    spacemember = SQLHandler.Instance.GetData($"Select Users.* from Users,Groups,Group_Member,Workspace_Space where Groups.Group_id= Group_Member.Group_id and Workspace_Space.Space_id={selectedSpaceId} and Groups.Space_id={selectedSpaceId} and Workspace_Space.Workspace_id={FWorkspace.Workspace_id}  and Group_Member.User_id=Users.User_id ");
                }


                cBAddPeople.DataSource = spacemember;
                cBAddPeople.DisplayMember = "User_name";
            }
        }

        private void lBPeopleList_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lBPeopleList.IndexFromPoint(e.Location); // Lấy chỉ số của mục dựa trên tọa độ con trỏ chuột

            if (index >= 0 && index < lBPeopleList.Items.Count) // Kiểm tra xem chỉ số có hợp lệ hay không
            {
                highlightedIndex = index; // Cập nhật chỉ số của mục đang được trỏ vào

                lBPeopleList.Invalidate(); // Yêu cầu ListBox vẽ lại để hiển thị dấu x
            }
        }

        private void lBPeopleList_Click(object sender, EventArgs e)
        {
            if (highlightedIndex >= 0 && highlightedIndex < lBPeopleList.Items.Count) // Kiểm tra xem chỉ số có hợp lệ hay không
            {
                var itemToRemove = userDictionary.FirstOrDefault(x => x.Value == lBPeopleList.Items[highlightedIndex].ToString());

                lBPeopleList.Items.RemoveAt(highlightedIndex); // Xóa mục tại chỉ số đã được trỏ vào



                if (itemToRemove.Key != 0)
                {
                    userDictionary.Remove(itemToRemove.Key);
                }

                highlightedIndex = -1; // Đặt lại trạng thái của mục đang được trỏ vào

                lBPeopleList.Invalidate(); // Yêu cầu ListBox vẽ lại để loại bỏ dấu x
            }
        }

        private void lBPeopleList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground(); // Vẽ nền của mục

            if (e.Index >= 0)
            {
                string itemText = lBPeopleList.Items[e.Index].ToString();

                if (e.Index == highlightedIndex) // Kiểm tra xem mục có đang được trỏ vào hay không
                {
                    // Vẽ dấu x trên mục đang được trỏ vào
                    e.Graphics.DrawString(itemText, e.Font, Brushes.Black, e.Bounds);
                    e.Graphics.DrawString("x", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top);
                }
                else
                {
                    // Vẽ mục thông thường
                    e.Graphics.DrawString(itemText, e.Font, Brushes.Black, e.Bounds);
                }
            }

            e.DrawFocusRectangle(); // Vẽ khung chọn
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
            string selectedFilePath = fileLabels[lblClicked];

            // Lấy thông tin về loại tệp tin
            string fileExtension = Path.GetExtension(selectedFilePath);
            string fileType = GetMimeType(fileExtension);

            // Xác định tên tệp tin khi lưu
            string fileName = Path.GetFileName(selectedFilePath);

            // Xử lý tải xuống tệp tin với loại tệp tin đúng
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = $"{fileType} Files|*{fileExtension}";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                File.Copy(selectedFilePath, savePath, true);
            }
        }

    }
}
