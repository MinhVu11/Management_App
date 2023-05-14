using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ManageProjectApp
{
    public partial class Form1 : Form
    {
        private bool isCollapseSpaces = false;
        private int spaceNum = 0;
        private int spaceHeight = 40;

        public Form1()
        {
            InitializeComponent();

            initSpaces();
        }

        private void initSpaces()
        {
            int spacesnnum = 0;
            List<string> spaces = new List<string>() { "Space 1", "Space 2", "Space 3", "Space 4" };

            foreach (var space in spaces)
            {
                Button btn = new Button();
                btn.Text = space;
                btn.Width = buttonSpaces.Width;
                btn.Height = spaceHeight;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn.Margin = new Padding(0, 0, 0, 0);
                flowLayoutPanelSpaces.Height += spaceHeight;
                flowLayoutPanelSpaces.Controls.Add(btn);
                spaceNum++;
            }

        }

        private void buttonSpaces_Click(object sender, EventArgs e)
        {

            if (isCollapseSpaces)
            {
                panelSpace.Height -= spaceNum * spaceHeight + buttonCreateNewSpace.Height + 20;
                isCollapseSpaces = false;
            }
            else
            {
                panelSpace.Height += spaceNum * spaceHeight + buttonCreateNewSpace.Height + 20;
                isCollapseSpaces = true;
            }
        
        }

        private void buttonCreateNewSpace_Click(object sender, EventArgs e)
        {
            FormCreateNewSpace1 formCreateSpace1 = new FormCreateNewSpace1();
            formCreateSpace1.ShowDialog();
        }
    }
}