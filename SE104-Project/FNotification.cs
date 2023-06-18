using System;
using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FNotification : Form
    {
        public FNotification()
        {
            InitializeComponent();
        }

        private void FNotification_Load(object sender, EventArgs e)
        {
            DataTable notifications = SQLHandler.Instance.GetData($"Select * from Notifications where User_id={FWorkspace.User_id}");
            foreach (DataRow row in notifications.Rows)
            {
                FNotification_US_Notification us = new FNotification_US_Notification(row);
                flpNotification.Controls.Add(us);

            }
        }
    }
}
