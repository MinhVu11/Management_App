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
    public partial class FCreateWorkspace : Form
    {
        public FCreateWorkspace()
        {
            InitializeComponent();
        }

        private void btnCreateWS_Click(object sender, EventArgs e)
        {
            if(tbWorkspaceName.Text=="")
            {
                MessageBox.Show("Please enter Workspace name");
            }    
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Workspace(Workspace_name) values('{tbWorkspaceName.Text}') ");
                DataTable data = SQLHandler.Instance.GetData("Select TOP 1 * from Workspace Order by Workspace_id DESC ");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Membership(User_id,Workspace_id,role) values({FWorkspace.User_id},{data.Rows[0]["Workspace_id"]},'Admin')");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
