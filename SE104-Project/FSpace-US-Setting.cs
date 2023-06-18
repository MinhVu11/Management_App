using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSpace_US_Setting : UserControl
    {
        private int highlightedIndex = -1; // Lưu chỉ số của mục đang được trỏ vào
        private int spaceid;
        public FSpace_US_Setting(int spaceid)
        {
            InitializeComponent();
            this.spaceid = spaceid;
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

            if (lBPeopleList.Items.Contains(selectedRow["User_name"].ToString().Trim()))
            {
                MessageBox.Show("User has been added");
            }
            else
            {
                lBPeopleList.Items.Add(selectedRow["User_name"].ToString().Trim());
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

        private void lBPeopleList_Click(object sender, EventArgs e)
        {
            if (highlightedIndex >= 0 && highlightedIndex < lBPeopleList.Items.Count) // Kiểm tra xem chỉ số có hợp lệ hay không
            {
                lBPeopleList.Items.RemoveAt(highlightedIndex); // Xóa mục tại chỉ số đã được trỏ vào
                highlightedIndex = -1; // Đặt lại trạng thái của mục đang được trỏ vào

                lBPeopleList.Invalidate(); // Yêu cầu ListBox vẽ lại để loại bỏ dấu x
            }
        }

        private void FSpace_US_Setting_Load(object sender, EventArgs e)
        {
            DataTable users = SQLHandler.Instance.GetData($"Select Users.* from users,Membership where users.user_id=membership.user_id and membership.workspace_id={FWorkspace.Workspace_id}");
            cBAddPeople.DataSource = users;
            cBAddPeople.DisplayMember = "User_name";
            DataTable space = SQLHandler.Instance.GetData($"Select * from Space where Space_id ={spaceid}");
            tbSpaceName.Text = space.Rows[0]["Space_name"].ToString().Trim();
            DataTable member = SQLHandler.Instance.GetData($"select users.* from Groups,Group_Member,Users where Groups.Group_id=Group_Member.Group_id and Users.User_id =Group_Member.User_id and Groups.Space_id={spaceid}");
            foreach (DataRow row in member.Rows)
            {
                lBPeopleList.Items.Add(row["User_name"].ToString().Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLHandler.Instance.ExcuteNonQuery($"Update Space set Space_name ='{tbSpaceName.Text}' where Space_id={spaceid}");

            DataTable spacedata = SQLHandler.Instance.GetData($"Select * from space where space_id={spaceid}");
            if (spacedata.Rows[0]["Space_type"].ToString().Trim() == "private")
            {
                DataTable Group = SQLHandler.Instance.GetData($"Select * from Groups where space_id={spaceid}");
                SQLHandler.Instance.ExcuteNonQuery($"Delete from Group_Member where Group_id={Group.Rows[0]["Group_id"]}");
                foreach (object item in lBPeopleList.Items)
                {
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Group_Member values({Group.Rows[0]["Group_id"]},,'Member')");
                }

            }

        }
    }
}
