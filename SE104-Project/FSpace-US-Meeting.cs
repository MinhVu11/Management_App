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
    public partial class FSpace_US_Meeting : UserControl
    {
        private int spaceid;
        public FSpace_US_Meeting(int spaceid)
        {
            InitializeComponent();
            this.spaceid = spaceid; 
        }

        private void FSpace_US_Meeting_Load(object sender, EventArgs e)
        {
            DataTable data = SQLHandler.Instance.GetData($"Select * from Meeting where Space_id={spaceid}");
            foreach(DataRow row in data.Rows)
            {
                US_Agenda us = new US_Agenda(Convert.ToInt32(row["Meeting_id"]));
                flpAgenda.Controls.Add(us);
            }
        }
    }
}
