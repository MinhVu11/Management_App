using System;
using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FMeeting_US_ListMeeting : UserControl
    {
        private TreeNode listChecked;
        private TreeNode listUnChecked;
        public FMeeting_US_ListMeeting()
        {
            InitializeComponent();
        }

        public void Loadpanel(object userControl)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            UserControl us = userControl as UserControl;
            this.pnMain.Controls.Add((Control)userControl);
            this.pnMain.Tag = userControl;
        }
        private void FMeeting_US_ListMeeting_Load(object sender, EventArgs e)
        {
            listChecked = new TreeNode();
            listUnChecked = new TreeNode();

            listChecked.Text = "List meeting unchecked";
            listUnChecked.Text = "List meeting checked";

            tvListMeeting.Nodes.Clear();
            tvListMeeting.Nodes.Add(listChecked);
            tvListMeeting.Nodes.Add(listUnChecked);
            loadMeetingList();
        }
        private void loadMeetingList()
        {
            DataTable checkedlist = SQLHandler.Instance.GetData($"Select * from Meeting where Meeting_Status='Checked'");
            DataTable uncheckedlist = SQLHandler.Instance.GetData($"Select * from Meeting where Meeting_Status='UnChecked'");
            
            foreach (DataRow row in checkedlist.Rows)
            {
                TreeNode nodex = new TreeNode(row["Meeting_name"].ToString().Trim())
                {
                    Tag = (int)row["Meeting_id"]
                };                
                listChecked.Nodes.Add(nodex);
            }
            foreach (DataRow row in uncheckedlist.Rows)
            {
                TreeNode nodey = new TreeNode(row["Meeting_name"].ToString().Trim())
                {
                    Tag = (int)row["Meeting_id"]
                };
                listUnChecked.Nodes.Add(nodey);
            }
        }

        private void tvListMeeting_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Tag != null)
            {
                Loadpanel(new US_EditMeeting((int)selectedNode.Tag));
            }
        }
    }
}
