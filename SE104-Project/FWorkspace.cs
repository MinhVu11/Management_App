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
    public partial class FWorkspace : Form
    {

        private bool isHaveSpace = false;
        public static int User_id;
        public FWorkspace()
        {
            InitializeComponent();
            initSpacesList();
            SubMenu();
        }

        private void SubMenu() 
        {
            flSpacesList.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            } 
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void hideSubMenu()
        {
            if (flSpacesList.Visible == true)
                flSpacesList.Visible = false;
        }
        private void initSpacesList()
        {
            List<string> spaces = new List<string>() { "Space 1", "Space 2", "Space 3", "Space 4", "Space 5","Space 6" };
      
            foreach (var space in spaces)
            {
                if (isHaveSpace == false)
                    isHaveSpace = true;
                Button btn = new Button();
                btn.Text = space;
                btn.Width = btnSpaces.Width;
                btn.Height = 40;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btn.ForeColor = Color.Black;
                btn.Margin = new Padding(0, 0, 0, 0);
                btn.BackColor = Color.White;
                flSpacesList.Controls.Add(btn);
            }
            if (!isHaveSpace)
            {
                flSpacesList.Height = 60;
            }
            else
            {
                flSpacesList.Height = 200;
            }

        }

        private void Workspace_Load(object sender, EventArgs e)
        { 
            FLogin lg = new FLogin();
            if(lg.ShowDialog() == DialogResult.OK)
            {
                FLoginWorspace lgws=new FLoginWorspace();
                if (lgws.ShowDialog() == DialogResult.OK)
                { }    
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSpaces_Click(object sender, EventArgs e)
        {
            showSubMenu(flSpacesList); 
           
        }
        private void buttonCreateNewSpace_Click(object sender, EventArgs e)
        {
            FCreateNewSpace formCreateSpace1 = new FCreateNewSpace();
            formCreateSpace1.ShowDialog();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Space_Click(object sender, EventArgs e)
        {
            showSubMenu(flSpacesList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCreateNewSpace FormCreateSpace = new FCreateNewSpace();
            FormCreateSpace.ShowDialog();
        }

        private void panelSpacesList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
