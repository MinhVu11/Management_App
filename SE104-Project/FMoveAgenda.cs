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
    public partial class FMoveAgenda : Form
    {
        private int meetingid;
        public FMoveAgenda(int meetingid)
        {
            InitializeComponent();
            this.meetingid = meetingid;
        }

        private void FMoveAgenda_Load(object sender, EventArgs e)
        {
            DataTable Spaces_data = SQLHandler.Instance.GetData($"select Space.* from Space, Workspace_Space where Space.Space_id = Workspace_Space.Space_id and Workspace_Space.Workspace_id = {FWorkspace.Workspace_id} ");
            cBIn.DataSource = Spaces_data;
            cBIn.DisplayMember = "Space_name";
            cBIn.ValueMember = "Space_id";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            SQLHandler.Instance.ExcuteNonQuery($"Update Meeting set Space_id={cBIn.SelectedValue} where Meeting_id={meetingid}");
        }
    }
}
