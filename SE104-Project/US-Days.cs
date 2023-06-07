using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_Days : UserControl
    {
        private List<string> events;
        public US_Days(List<string> events=null)
        {
            InitializeComponent();
            this.events = events;
        }

        private void US_Days_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbDays.Text = numday + "";
        }

        private void displayEvent()
        {

        }
    }
}
