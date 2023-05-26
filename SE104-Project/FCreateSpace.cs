using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE104_Project;

namespace ManageProjectApp
{
    public partial class FCreateSpace : Form
    {
        public FCreateSpace()
        {
            InitializeComponent();
        }
        private void buttonNext1_Click(object sender, EventArgs e)
        {
            if (tbSpaceName.Text == "")
                MessageBox.Show("Please enter Workspace name");  
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Space(Space_name) values('{tbSpaceName.Text}') ");
                DataTable data = SQLHandler.Instance.GetData("Select TOP 1 * from Space Order by Workspace_id DESC ");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Workspace_Space(Workspace_id,Space_id) values({FWorkspace.User_id},{data.Rows[0]["Space_id"]})");
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
}
