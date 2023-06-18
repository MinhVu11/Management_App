using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FMeeting : Form
    {
        public FMeeting()
        {
            InitializeComponent();
        }

        private void FMeeting_Load(object sender, EventArgs e)
        {
            if(FWorkspace.isAdmin)
            {
                Loadpanel(new FMeeting_US_ListMeeting());
            }    
            
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

        private void btnNewMeeting_Click(object sender, EventArgs e)
        {
            FCreateMeeting f= new FCreateMeeting();
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (FWorkspace.isAdmin)
                {
                    Loadpanel(new FMeeting_US_ListMeeting());
                }
                
            }

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if(FWorkspace.isAdmin)
            {
                Loadpanel(new US_Calendar());

            }
            else
            {
                MessageBox.Show("Bạn không có quyền admin");
            }
            
        }

        private void btnMeetingList_Click(object sender, EventArgs e)
        {
            if (FWorkspace.isAdmin)
            {
                Loadpanel(new FMeeting_US_ListMeeting());

            }
            else
            {
                MessageBox.Show("Bạn không có quyền admin");
            }
        }
    }
}
