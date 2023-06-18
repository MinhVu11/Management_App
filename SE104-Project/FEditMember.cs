using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FEditMember : Form
    {
        public FEditMember(string username,string userfullname,String email,DateTime birthday)
        {
            InitializeComponent();
            tbUserName.Text = username;
            tbFullName.Text = userfullname;
            tbEmail.Text = email;
            dtpBirthday.Value = birthday;
            cbbRole.SelectedItem = "Member";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select * from Users where User_email='{tbEmail.Text}'");
            if(data.Rows.Count > 0)
            {
                SQLHandler.Instance.ExcuteNonQuery($"Delete from Membership where User_id={data.Rows[0]["User_id"]} and Workspace_id={FWorkspace.Workspace_id}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select * from Users where User_email='{tbEmail.Text}'");
            if (data.Rows.Count > 0)
            {
                SQLHandler.Instance.ExcuteNonQuery($"Update Membership set Role='{cbbRole.SelectedItem}' where User_id={data.Rows[0]["User_id"]} and Workspace_id={FWorkspace.Workspace_id}");
            }
        }

      

        private void FEditMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;

        }
    }
}
