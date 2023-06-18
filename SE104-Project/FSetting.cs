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
    public partial class FSetting : Form
    {
        public delegate void LogoutClickedEventHandler();
        public event LogoutClickedEventHandler LogoutClicked;
        public FSetting()
        {
            InitializeComponent();
        }
     
        public void Loadpanel(object userControl)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            UserControl us=userControl as UserControl;
            this.pnMain.Controls.Add((Control)userControl);
            this.pnMain.Tag = userControl;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Loadpanel(new FSetting_US_Setting());
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Loadpanel(new FSetting_US_People());
        }

        private void FSetting_Load(object sender, EventArgs e)
        {
            Loadpanel(new FSetting_US_Setting());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Loadpanel(new FSetting_US_Profile());
        }

        private void btnWorkspace_Click(object sender, EventArgs e)
        {
            FSetting_US_Workspace f=new FSetting_US_Workspace();
            f.ButtonClicked += btnBack_Click;
            Loadpanel(f);
            
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnLogout_Click(object sender, EventArgs e)      
        {            
            LogoutClicked?.Invoke();
            this.Close();
            
        }
    }
}
