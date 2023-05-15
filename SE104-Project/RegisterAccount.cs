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
    public partial class RegisterAccount : Form
    {
        public RegisterAccount()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Please enter username!");
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!");
            }
            else if (tbFullName.Text=="")
            {
                MessageBox.Show("Please enter your full name");
            }
            else if (tbEmail.Text=="")
            {
                MessageBox.Show("Please enter your email");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Users(User_fullname,User_name,User_password,User_email) values('{tbUserName.Text}','{tbUserName.Text}','{tbPassword.Text}','{tbEmail.Text}')");
                DialogResult = DialogResult.OK;
            }
        }

        private void llbFogotPS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void RegisterAccount_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSignUp;
        }
    }
}
