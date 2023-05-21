using ManageProjectApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FWorkspace : Form
    {
        public static int User_id;
        public static int Workspace_id;
        private bool showPanelSpace = false;
        private bool isDragging = false;
        private Point lastMousePosition;
        public FWorkspace()
        {
            InitializeComponent();
           
            //initSpaces();
            tooglePanels();

        }

        private void Workspace_Load(object sender, EventArgs e)
        { 
            FLogin lg = new FLogin();
            if(lg.ShowDialog() == DialogResult.OK)
            {
                FLoginWorspace lgws = new FLoginWorspace();
                if (lgws.ShowDialog() == DialogResult.OK)
                {
                    Loadspaces();
                }    
            }

        }

        private void Loadspaces()
        {
            // button new space
            Button newspace=new Button();
            newspace.Margin = new Padding(0, 0, 0, 0);
            newspace.Size = new Size(flpSpace.Width, 25);
            newspace.Text = "New";
            newspace.Click += btnNewSpace_Click;
            newspace.BackColor = Color.Red;
            flpSpace.Controls.Add(newspace);
            List<Space> publicspaces = Space.GetPublicSpace();
            List<Space> privatespaces = Space.GetPrivateSpace();
            foreach (Space publicspace in publicspaces)
            {
                Button btn = new Button();
                btn.Dock = DockStyle.Top;
                btn.BackColor = Color.White;
                btn.Margin = new Padding(0, 0, 0, 0);
                btn.Size = new Size(flpSpace.Width, 25);
                btn.Tag = publicspace.Space_id;
                btn.Text = publicspace.Space_name;
                btn.Click += btnRealSpace_Click;
                flpSpace.Controls.Add(btn);
            }
            foreach (Space privatespace in privatespaces)
            {
                Button btn = new Button();
                btn.Dock = DockStyle.Top;
                btn.BackColor = Color.White;
                btn.Margin = new Padding(0, 0, 0, 0);
                btn.Size = new Size(flpSpace.Width, 25);
                btn.Tag = privatespace.Space_id;
                btn.Text = privatespace.Space_name;
                btn.Image = Properties.Resources.lockicon;
                btn.Click += btnRealSpace_Click;
                flpSpace.Controls.Add(btn);
            }
        }

      

        private void tooglePanels()
        {
            if(showPanelSpace)
            {
                int buttonCount = flpSpace.Controls.OfType<Button>().Count();
                flpSpace.Height = 25 * buttonCount;
            }
            else
            {
                flpSpace.Height = 0;
            } 
                
        }  
        public void Loadform(object Form)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();


        }
        private void btnSpace_Click(object sender, EventArgs e)
        {
            showPanelSpace = !showPanelSpace;
            tooglePanels();
        }
        private void btnNewSpace_Click(object sender,EventArgs e)
        {
            FormCreateNewSpace1 f=new FormCreateNewSpace1();
            f.ShowDialog();            
        }
        private void btnRealSpace_Click(object sender, EventArgs e)
        {
            Loadform(new FSpace());
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }          
            else
            {
                WindowState = FormWindowState.Normal;
            }    
                
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnMain_Resize(object sender, EventArgs e)
        {
        }

        private void pnHead_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastMousePosition = e.Location;
        }

        private void pnHead_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pnHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Loadform(new FDashboard());
        }
    }
}
