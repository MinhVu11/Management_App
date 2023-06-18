using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FCreateTask : Form
    {
        private int highlightedIndex = -1; // Lưu chỉ số của mục đang được trỏ vào
        private int chosen_User;
        private Dictionary<int, string> userDictionary = new Dictionary<int, string>();

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
                lBPeopleList.Items.RemoveAt(highlightedIndex); // Xóa mục tại chỉ số đã được trỏ vào

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
    }
}
