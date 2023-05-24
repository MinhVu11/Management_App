using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FCreateNewSpace : Form
    {
        public FCreateNewSpace()
        {
            InitializeComponent();
        }

        private void btnCreateSpace_Click(object sender, System.EventArgs e)
        {
            if (tbSpaceName.Text == "")
            {
                MessageBox.Show("Enter Your Space Name");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Space(Space_name) values('{tbSpaceName.Text}') ");
                DataTable data = SQLHandler.Instance.GetData("Select TOP 1 * from Space Order by Space_id DESC ");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Space_User(User_id,Space_id,Role) values({FWorkspace.User_id},{data.Rows[0][""]},'Admin')");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
