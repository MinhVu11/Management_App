using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectApp
{
    public partial class FCreateNewSpace1 : Form
    {
        public FCreateNewSpace1()
        {
            InitializeComponent();
        }
        private void buttonNext1_Click(object sender, EventArgs e)
        {
            FCreateNewSpace2 f2 = new FCreateNewSpace2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
