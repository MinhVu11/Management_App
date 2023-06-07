using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FCreateTask : Form
    {
        private int highlightedIndex = -1; // Lưu chỉ số của mục đang được trỏ vào
        private int chosen_User;
        public FCreateTask()
        {
            InitializeComponent();
            lBPeopleList.DrawMode = DrawMode.OwnerDrawFixed;
            Load();
        }

        private void Load()
        {
            // Load comboBox Danh sach Space
            // 
            DataTable Spaces_data = SQLHandler.Instance.GetData($"select Space.* from Space, Workspace_Space where Space.Space_id = Workspace_Space.Space_id and Workspace_Space.Workspace_id = {FWorkspace.Workspace_id} ");
            cBIn.DataSource = Spaces_data;
            cBIn.DisplayMember = "Space_name";
            cBIn.ValueMember = "Space_id";


            //// Load Combo Box Add People
            //DataRowView selectedRow = (DataRowView)cBIn.SelectedItem;

            //int Selected_Space_id = (int)cBIn.SelectedValue;
            //DataTable spacemember = new DataTable();
            //if (selectedRow["Space_type"].ToString()=="Public")
            //{
            //    spacemember = SQLHandler.Instance.GetData("Select * from ");
            //}    

            //DataTable User_data = SQLHandler.Instance.GetData($"select * from USers, Space, Space_User where {Selected_Space_id} = Space_Users.Space_id and Space_Users.User_id = Users.User_id ");
            //cBAddPeople.DataSource = User_data;
            //cBAddPeople.DisplayMember = "User_name";
            //cBAddPeople.ValueMember = "User_id";
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if (tbTaskName.Text == "")
            {
                MessageBox.Show("Please enter Your Task Name");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task(Task_name, Task_description, Task_status, Task_start time, Task_end_time) values('{tbTaskName.Text}', '{rTBTaskDescription.Text}', '{cBStatus.Text}', '{dTPStartDate.Text}', '{dTPEndDate.Text}' ) ");
                DataTable Task_Space_data = SQLHandler.Instance.GetData($"select TOP 1 * from Task_Space Order by Task_Space_id DESC");
                DataTable Task_data = SQLHandler.Instance.GetData($"select TOP 1 * from Task Order by Task_id DESC");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task_Space(Task_id, Space_id) values ({Task_data.Rows[0]},{cBIn})");

                foreach (object item in lBPeopleList.Items)
                {
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Assignment( Task_id, User_id) values ('{Task_Space_data.Rows[0]} + 1', '')");

                }
                Close();
            }
        }

        private void cBAddPeople_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cBAddPeople.SelectedItem;
            DataTable Chosen_User_Name = SQLHandler.Instance.GetData($"Select USer_name from Users where Users.USer_id = {selectedRow["User_id"]}");

            if (Chosen_User_Name.Rows.Count > 0)
            {
                string userName = Chosen_User_Name.Rows[0]["User_name"].ToString();
                if (lBPeopleList.Items.Contains(userName))
                {
                    MessageBox.Show("User has been added");
                }
                else
                {
                    lBPeopleList.Items.Add(userName);
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
