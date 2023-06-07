using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_CreateTask : UserControl
    {
        public US_CreateTask()
        {
            InitializeComponent();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            FCreateTask f = new FCreateTask();
            f.ShowDialog();
        }
    }
}
