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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            tbPassword.PasswordChar= '*';
        }

   

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable data= new DataTable();
            data = SQLHandler.Instance.GetData($"Select * from Users where User_name='{tbUserName.Text}'");
            if(tbUserName.Text=="")
            {
                MessageBox.Show("Please enter username!");
            }    
            else if(tbPassword.Text=="")
            {
                MessageBox.Show("Please enter password!");
            }    
            else if(data.Rows.Count==0)
            {
                MessageBox.Show("User name is not exist!");
            }
            else if (data.Rows[0]["User_password"].ToString().Trim() != tbPassword.Text)
            {
                MessageBox.Show($"Incorrect Password!,{data.Rows[0]["User_password"].ToString()}");
            }
            else
            {
                FWorkspace.User_id = (int)data.Rows[0]["User_id"];
                MessageBox.Show($"Hello {tbUserName.Text}");
                DialogResult = DialogResult.OK;

            }
           
        }


        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRegisterAccount su = new FRegisterAccount();
            if (su.ShowDialog() == DialogResult.Cancel)
            {
                //Close();
            }
        }

        private void llbFogotPS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FFogotPassword fp = new FFogotPassword();
            if (fp.ShowDialog() == DialogResult.Cancel)
            {
                //Close();
            }
        }
    }
}
