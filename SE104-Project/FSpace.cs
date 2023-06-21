using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSpace : Form
    {
        private int spaceid;
        private bool isPrivate = false;
        public FSpace(int id)
        {

            InitializeComponent();
            this.spaceid = id;
            DataTable data = SQLHandler.Instance.GetData($"Select * from space where space_id={spaceid}");
            if (data.Rows[0]["Space_type"].ToString().Trim().ToLower() == "private")
            {
                isPrivate = true;
            }
            else
            {
                isPrivate = false;
            }
        }

        private void FSpace_Load(object sender, System.EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select * from Space where Space_id={spaceid}");
            lbSpaceName.Text = data.Rows[0]["Space_name"].ToString().Trim();
        }
        public void Loadpanel(object userControl)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            UserControl us = userControl as UserControl;
            this.pnMain.Controls.Add((Control)userControl);
            this.pnMain.Tag = userControl;
        }

        private void btnList_Click(object sender, System.EventArgs e)
        {
            FSpace_US_List us = new FSpace_US_List();
            us.Spaceid = this.spaceid;
            Loadpanel(us);

        }

        private void btnCalendar_Click(object sender, System.EventArgs e)
        {
            Loadpanel(new US_Calendar(spaceid));
        }

        private void btnMeeting_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, System.EventArgs e)
        {
            if (isPrivate)
            {
                DataTable adminspace = SQLHandler.Instance.GetData($"Select Group_Member.* from Group_member,Groups where Group_member.Group_id=Groups.Group_id and Groups.Space_id={spaceid} and Group_member.User_id={FWorkspace.User_id}");
                if (adminspace.Rows[0]["role"].ToString().Trim().ToLower() == "admin")
                {
                    Loadpanel(new FSpace_US_Setting(spaceid));

                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập");
                }

            }
            else
            {
                if (FWorkspace.isAdmin)
                {
                    Loadpanel(new FSpace_US_Setting(spaceid));

                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập");
                }
            }

        }
    }
}
