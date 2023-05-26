using System;
using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSetting_US_Setting : UserControl
    {
        public FSetting_US_Setting()
        {
            InitializeComponent();
        }

        private void FSetting_US_Setting_Load(object sender, EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select * from Workspace where Workspace_id={FWorkspace.Workspace_id}");
            tbWorkspaceName.Text = data.Rows[0]["Workspace_name"].ToString().Trim();
        }

    }
}
