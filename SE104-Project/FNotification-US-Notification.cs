using System;
using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FNotification_US_Notification : UserControl
    {
        private readonly DataRow row;
        public FNotification_US_Notification(DataRow row)
        {
            InitializeComponent();
            this.row = row;

        }

        private void FNotification_US_Notification_Load(object sender, EventArgs e)
        {
            if (row["Notification_type"].ToString().Trim() == "Task")
            {
                DataTable task = SQLHandler.Instance.GetData($"Select * from task where task_id={row["Event_id"]}");
                lbName.Text = task.Rows[0]["Task_name"].ToString().Trim();
                tbDescription.Text = task.Rows[0]["Task_description"].ToString().Trim();

            }
            else if (row["Notification_type"].ToString().Trim() == "Meeting")
            {
                DataTable meeting = SQLHandler.Instance.GetData($"Select * from Meeting where Meeting_id={row["Event_id"]}");
                lbName.Text = meeting.Rows[0]["Meeting_name"].ToString().Trim();
                tbDescription.Text = meeting.Rows[0]["Meeting_description"].ToString().Trim();
            }
            lbCreateAt.Text = row["Created_at"].ToString().Trim();
        }
     

        private void FNotification_US_Notification_Click(object sender, EventArgs e)
        {
       
            if (row["Notification_type"].ToString().Trim().ToLower() == "task")
            {
                FEditTask f = new FEditTask(Convert.ToInt32(row["Event_id"]));
                f.ShowDialog();

            }
            else if (row["Notification_type"].ToString().Trim().ToLower() == "meeting")
            {
                Form f = new Form();
                US_EditMeeting us = new US_EditMeeting(Convert.ToInt32(row["Event_id"]));
                f.Controls.Add(us);
                f.AutoSize = true;
                us.Dock = DockStyle.Fill;
                f.ShowDialog();
            }
            SQLHandler.Instance.ExcuteNonQuery($"Update Notifications set IsRead=1 where Notification_id={row["Notification_id"]}");
        }
    }
}
