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
    public partial class FLoginWorspace : Form
    {
        public FLoginWorspace()
        {
            InitializeComponent();
        }
        public List<Workspace> GetWorkspaces()
        {
            List<Workspace> list = new List<Workspace>();
            DataTable data=new DataTable();
            data = SQLHandler.Instance.GetData($"Select * from Membership where User_id={FWorkspace.User_id}");
            foreach (DataRow item in data.Rows)
            {
                int id = (int)item["Workspace_id"];
                DataTable dt = SQLHandler.Instance.GetData($"Select * from Workspace where Workspace_id={id}");
                string name = dt.Rows[0]["Workspace_name"].ToString();
                Workspace workspace=new Workspace(id,name);
                list.Add(workspace);
            }
            return list;
        }
        void LoadWorkspaces()
        {
            List<Workspace> list = GetWorkspaces();
            foreach (Workspace workspace in list)
            {
                Button btn = new Button();
                btn.Text = workspace.Workspace_name;
                btn.BackColor=Color.FromArgb(255,255,255);
                btn.Click += btnWorkspace_Click;
                flpWorkspaces.Controls.Add(btn);
            }
        }
        private void btnWorkspace_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void llbCreateNewWS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCreateWorkspace fcws=new FCreateWorkspace();
            if(fcws.ShowDialog(Owner) == DialogResult.OK)
            {

            }
        }

        private void FLoginWorspace_Load(object sender, EventArgs e)
        {
            LoadWorkspaces();
        }
    }
}
