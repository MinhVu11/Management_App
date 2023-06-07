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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLHandler.Instance.ExcuteNonQuery($"Update Workspace set Workspace_name='{tbWorkspaceName.Text}' where Workspace_id={FWorkspace.Workspace_id}");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả từ hộp thoại MessageBox
            if (result == DialogResult.Yes)
            {
                //
            }
            
        }
    }
}
