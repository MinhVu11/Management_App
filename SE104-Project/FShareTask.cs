using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SE104_Project
{
    public partial class FShareTask : Form
    {
        private int taskid;
        private int highlightedIndex = -1; // Lưu chỉ số của mục đang được trỏ vào
        private int chosen_User;
        private Dictionary<int, string> userDictionary = new Dictionary<int, string>();
        public FShareTask(int taskid)
        {
            InitializeComponent();
            this.taskid = taskid;
        }
        private void FShareTask_Load(object sender, EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select users.* from users,sharetask where users.user_id=sharetask.user_id and sharetask.task_id={taskid}");
            foreach(DataRow row in data.Rows)
            {
                userDictionary.Add(Convert.ToInt32(data.Rows[0]["User_id"]), data.Rows[0]["User_name"].ToString().Trim());
                lBPeopleList.Items.Add(data.Rows[0]["User_name"].ToString().Trim());
            }
            DataTable user = SQLHandler.Instance.GetData($"Select users.* from users,membership where users.user_id = membership.user_id and membership.workspace_id={FWorkspace.Workspace_id}");
            foreach (DataRow row in user.Rows)
            {
                row["User_name"] = row["User_name"].ToString().Trim();
            }
            cBAddPeople.DataSource=user;
            cBAddPeople.DisplayMember = "User_name";
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

        private void lBPeopleList_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lBPeopleList.IndexFromPoint(e.Location); // Lấy chỉ số của mục dựa trên tọa độ con trỏ chuột

            if (index >= 0 && index < lBPeopleList.Items.Count) // Kiểm tra xem chỉ số có hợp lệ hay không
            {
                highlightedIndex = index; // Cập nhật chỉ số của mục đang được trỏ vào

                lBPeopleList.Invalidate(); // Yêu cầu ListBox vẽ lại để hiển thị dấu x
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

        private void btnShare_Click(object sender, EventArgs e)
        {
            foreach(var item in lBPeopleList.Items)
            {
                SQLHandler.Instance.ExcuteNonQuery($"Delete from sharetask where sharetask.task_id={taskid}");
                int userID = userDictionary.FirstOrDefault(x => x.Value ==item.ToString()).Key;
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Sharetask(user_id,task_id) values({userID},{taskid})");
                
            }
        }
    }
}
