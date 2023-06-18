using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SE104_Project
{
    public partial class FRegisterAccount : Form
    {
        public FRegisterAccount()
        {
            InitializeComponent();
            tbPassword.PasswordChar= '*';
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
                try
                {
                    MailAddress mailAddress = new MailAddress(tbEmail.Text);
                    
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Users(User_fullname,User_name,User_password,User_email) values('{tbFullName.Text}','{tbUserName.Text}','{tbPassword.Text}','{tbEmail.Text}')");
                    DialogResult = DialogResult.OK;
                }
                catch (FormatException)
                {
                    MessageBox.Show($"{tbEmail.Text} is not a valid email address.");
                   
                }
                
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
