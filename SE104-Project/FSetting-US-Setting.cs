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
            if (FWorkspace.isAdmin)
            {
                SQLHandler.Instance.ExcuteNonQuery($"Update Workspace set Workspace_name='{tbWorkspaceName.Text}' where Workspace_id={FWorkspace.Workspace_id}");
            }
            else
            {
                MessageBox.Show("Bạn không có quyền admin");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FWorkspace.isAdmin)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Xử lý kết quả từ hộp thoại MessageBox
                if (result == DialogResult.Yes)
                {
                    //
                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền admin");
            }


        }
    }
}
