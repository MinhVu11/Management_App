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
    public partial class FogotPassword : Form
    {
        public FogotPassword()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataTable data=new DataTable();
            data = SQLHandler.Instance.GetData($"Select * from Users where User_email='{tbEmail.Text}'");
            if(data.Rows.Count==0)
            {
                MessageBox.Show("Email is not exist!");
            }
            else
            {
                lbEmail.Visible= false;
                tbEmail.Visible= false;
                btnCancel.Visible = false;
                lbPassword.Visible = true;
                tbPassword.Visible = true;
                btnBack.Visible = true;
                btnDone.Visible = true;
                
            }              
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lbEmail.Visible = true;
            tbEmail.Visible = true;
            btnCancel.Visible = true;
            lbPassword.Visible = false;
            tbPassword.Visible = false;
            btnBack.Visible = false;
            btnDone.Visible = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            SQLHandler.Instance.ExcuteNonQuery($"Update Users set User_password='{tbPassword.Text}' where User_email='{tbEmail.Text}'");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
