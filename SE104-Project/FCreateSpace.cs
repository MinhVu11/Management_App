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
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Space(Space_name,Space_type) values('{tbSpaceName.Text}','{cbbType.SelectedItem}') ");
                DataTable data = SQLHandler.Instance.GetData("Select TOP 1 * from Space Order by Space_id DESC ");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Workspace_Space(Workspace_id,Space_id) values({FWorkspace.User_id},{data.Rows[0]["Space_id"]})");
                if (cbbType.SelectedItem == "Private")
                {
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Groups(Space_id) values({data.Rows[0]["Space_id"]})");
                    DataTable groupdata = SQLHandler.Instance.GetData("Select TOP 1 * from Groups Order by Group_id DESC");
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Group_Member(Group_id,User_id,role) values({groupdata.Rows[0]["Group_id"]},{FWorkspace.User_id},'Admin')");
                }    
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void FCreateSpace_Load(object sender, EventArgs e)
        {
            cbbType.SelectedItem = "Public";
        }
    }
}
