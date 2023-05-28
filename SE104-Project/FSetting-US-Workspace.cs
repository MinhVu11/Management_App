using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSetting_US_Workspace : UserControl
    {
        Button AddNew = new Button();
        private int buttonHeight = 60;
        private int buttonWidth = 80;
        public event EventHandler ButtonClicked;
        public FSetting_US_Workspace()
        {
            InitializeComponent();
        }
        public List<Workspace> GetWorkspaces()
        {
            List<Workspace> list = new List<Workspace>();
            DataTable data = new DataTable();
            data = SQLHandler.Instance.GetData($"Select * from Membership where User_id={FWorkspace.User_id}");
            foreach (DataRow item in data.Rows)
            {
                int id = (int)item["Workspace_id"];
                DataTable dt = SQLHandler.Instance.GetData($"Select * from Workspace where Workspace_id={id}");
                string name = dt.Rows[0]["Workspace_name"].ToString();
                Workspace workspace = new Workspace(id, name);
                list.Add(workspace);
            }
            return list;
        }
        void LoadWorkspaces()
        {
            if (flpWorkspaces.Controls.Count > 0)
            {
                flpWorkspaces.Controls.Clear();
            }
            List<Workspace> list = GetWorkspaces();
            foreach (Workspace workspace in list)
            {
                Button btn = new Button();
                btn.Text = workspace.Workspace_name;
                btn.BackColor = Color.FromArgb(255, 255, 255);
                btn.Tag = workspace.Workspace_id;
                btn.Click += btnWorkspace_Click;
                btn.Size = new Size(buttonWidth, buttonHeight);
                btn.ForeColor = Color.FromArgb(0, 0, 0);
                flpWorkspaces.Controls.Add(btn);
            }


            flpWorkspaces.Controls.Add(AddNew);
        }
        private void btnWorkspace_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            FWorkspace.Workspace_id = (int)btn.Tag;
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            FCreateWorkspace fcws = new FCreateWorkspace();
            if (fcws.ShowDialog() == DialogResult.OK)
            {
                LoadWorkspaces();
            }

        }

        private void Addnew_MouseEnter(object sender, EventArgs e)
        {
            // Thay đổi màu nền của button khi trỏ vào
            AddNew.BackColor = Color.DarkBlue;
        }

        private void Addnew_MouseLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền ban đầu của button khi rời chuột khỏi nó
            AddNew.BackColor = Color.LightSteelBlue;
        }

        private void FSetting_US_Workspace_Load(object sender, EventArgs e)
        {
            AddNew.Text = "Add new";
            AddNew.TextAlign = ContentAlignment.MiddleCenter;
            AddNew.Click += btnAddnew_Click;
            AddNew.Cursor = Cursors.Hand;
            AddNew.Size = new Size(buttonWidth, buttonHeight);
            AddNew.BackColor = Color.LightSteelBlue;
            AddNew.MouseEnter += Addnew_MouseEnter;
            AddNew.MouseLeave += Addnew_MouseLeave;
            LoadWorkspaces();
        }
    }
}
