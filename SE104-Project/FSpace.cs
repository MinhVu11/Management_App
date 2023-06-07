using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSpace : Form
    {
        private int spaceid;
        
        public FSpace(int id)
        {
           
            InitializeComponent();
            this.spaceid = id;
        }

        private void FSpace_Load(object sender, System.EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select * from Space where Space_id={spaceid}");
            lbSpaceName.Text = data.Rows[0]["Space_name"].ToString().Trim();
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

        private void btnList_Click(object sender, System.EventArgs e)
        {
            FSpace_US_List us= new FSpace_US_List();
            us.Spaceid= this.spaceid;
            Loadpanel(us);

        }

        private void btnCalendar_Click(object sender, System.EventArgs e)
        {
            Loadpanel(new FSpace_US_Calendar(spaceid));    
        }

        private void btnMeeting_Click(object sender, System.EventArgs e)
        {

        }
    }
}
