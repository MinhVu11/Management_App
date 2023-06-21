using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSetting_US_People : UserControl
    {
        public FSetting_US_People()
        {
            InitializeComponent();

        }

        private void FSetting_US_People_Load(object sender, EventArgs e)
        {
            cbbRole.SelectedItem = "Member";
            tbSearch.Text = "Search by username";
            tbSearch.ForeColor = SystemColors.GrayText;
            tbAddMember.Text = "Invite by email";
            tbAddMember.ForeColor = SystemColors.GrayText;

            LoadDataGridView();
            dgvMembers.Rows[0].Cells[0].Style.BackColor = Color.Blue;

        }

        private void LoadDataGridView()
        {
            DataTable data = SQLHandler.Instance.GetData($"Select User_name,User_fullname,User_email,Role,User_birthday from Users,MemberShip where MemberShip.User_id=Users.User_id and Workspace_id={FWorkspace.Workspace_id}");
            dgvMembers.DataSource = data;
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvMembers.DataSource != null)
            {
                string searchTerm = tbSearch.Text;
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvMembers.DataSource];
                foreach (DataGridViewRow row in dgvMembers.Rows)
                {
                    if (searchTerm == "" || searchTerm == "Search by username")
                    {
                        currencyManager.SuspendBinding(); // Tạm dừng việc ràng buộc dữ liệu
                        row.Visible = true;
                        currencyManager.ResumeBinding(); // Tiếp tục ràng buộc dữ liệu
                    }
                    else if (!row.Cells[2].Value.ToString().ToLower().Contains(searchTerm.ToLower()))
                    {
                        currencyManager.SuspendBinding();
                        row.Visible = false;
                        currencyManager.ResumeBinding();
                    }
                    else
                    {
                        currencyManager.SuspendBinding();
                        row.Visible = true;
                        currencyManager.ResumeBinding();
                    }
                }
            }


        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            // Clear the hint text when the control receives focus
            if (tbSearch.Text == "Search by username")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            // Restore the hint text if the control is empty
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                tbSearch.Text = "Search by username";
                tbSearch.ForeColor = SystemColors.GrayText;

            }
        }

        private void tbAddMember_Leave(object sender, EventArgs e)
        {
            // Restore the hint text if the control is empty
            if (string.IsNullOrWhiteSpace(tbAddMember.Text))
            {
                tbAddMember.Text = "Invite by email";
                tbAddMember.ForeColor = SystemColors.GrayText;

            }

        }

        private void tbAddMember_Enter(object sender, EventArgs e)
        {
            // Clear the hint text when the control receives focus
            if (tbAddMember.Text == "Invite by email")
            {
                tbAddMember.Text = "";
                tbAddMember.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (FWorkspace.isAdmin)
            {
                DataTable data = SQLHandler.Instance.GetData($"Select * from Users where User_email='{tbAddMember.Text}'");
                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("User is not exist!");
                }
                else
                {
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Membership values ({(int)data.Rows[0]["User_id"]},{FWorkspace.Workspace_id},'{cbbRole.SelectedItem}')");
                    LoadDataGridView();
                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền admin");
            }

        }

        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                FEditMember f = new FEditMember(row.Cells["User_name"].Value.ToString().Trim(), row.Cells["User_fullname"].Value.ToString().Trim(), row.Cells["User_email"].Value.ToString().Trim(), (DateTime)row.Cells["User_birthday"].Value);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadDataGridView();
                }
            }
        }
    }
}
