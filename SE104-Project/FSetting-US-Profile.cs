using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSetting_US_Profile : UserControl
    {
        DataTable data;
        public FSetting_US_Profile()
        {
            InitializeComponent();
        }

        private void FSetting_US_Profile_Load(object sender, EventArgs e)
        {
            data = SQLHandler.Instance.GetData($"Select * from Users where User_id={FWorkspace.User_id}");
            tbUsername.Text = data.Rows[0]["User_name"].ToString().Trim();
            tbFullname.Text = data.Rows[0]["User_fullname"].ToString().Trim();
            tbEmail.Text = data.Rows[0]["User_email"].ToString().Trim();
            tbPassword.Text = "Enter New Password";
            tbPassword.PasswordChar = '*';
            tbPassword.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Enter user name");
            }
            else if (tbFullname.Text=="")
            {
                MessageBox.Show("Enter full name");
            }
            else if(tbPassword.Text=="Enter New Password"||tbPassword.Text=="")
            {
                MessageBox.Show("Enter Password");
            } 
            else if(tbEmail.Text=="")
            {
                MessageBox.Show("Enter email");
            }    
            else
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(tbEmail.Text);            
                    SQLHandler.Instance.ExcuteNonQuery($"Update Users set User_fullname='{tbFullname.Text}',User_name='{tbUsername.Text}',User_password='{tbPassword.Text}',User_email='{tbEmail.Text}' where User_id={data.Rows[0]["User_id"]}");
                }
                catch (FormatException)
                {
                    MessageBox.Show($"{tbEmail.Text} is not a valid email address.");

                }
            }
        }
    }
}
