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
    public partial class FormCreateNewSpace1 : Form
    {
        public FormCreateNewSpace1()
        {
            InitializeComponent();
        }
        private void buttonNext1_Click(object sender, EventArgs e)
        {
            FormCreateNewSpace2 f2 = new FormCreateNewSpace2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
