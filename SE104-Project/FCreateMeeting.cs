using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FCreateMeeting : Form
    {
        Label lb = new Label();
        public FCreateMeeting()
        {
            InitializeComponent();
            Controls.Add(lb);
        }

        private void FCreateMeeting_Load(object sender, EventArgs e)
        {
            cbStart.SelectedItem = "12:00";
            cbEnd.SelectedItem = "12:30";
            DataTable userdata = SQLHandler.Instance.GetData($"Select * from Users where User_id={FWorkspace.User_id}");
            tbOrganizer.Text = userdata.Rows[0]["User_email"].ToString().Trim();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                MessageBox.Show("Please enter tilte");
            }
            else
            {
                DateTime starttime = dtpStarttime.Value.Date.Add(TimeSpan.Parse(cbStart.SelectedItem.ToString()));
                DateTime endtime = dtpEndtime.Value.Date.Add(TimeSpan.Parse(cbEnd.SelectedItem.ToString()));
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Meeting(Organizer_id,Meeting_name,Meeting_Start_time,Meeting_end_time,Meeting_description,Meeting_status,Workspace_id) values({FWorkspace.User_id},'{tbTitle.Text}','{starttime}','{endtime}','{tbDesciption.Text}','UnChecked',{FWorkspace.Workspace_id})");
                DataTable meeting = SQLHandler.Instance.GetData("SELECT TOP 1 * FROM meeting ORDER BY Meeting_id DESC");

                SQLHandler.Instance.ExcuteNonQuery($"Insert into Participants values({meeting.Rows[0]["meeting_id"]},{meeting.Rows[0]["Organizer_id"]})");
                string[] strings = tbRequired.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(string str in strings)
                {
                    DataTable participant =SQLHandler.Instance.GetData($"Select * from Users where User_email='{str}'");
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Participants values({meeting.Rows[0]["Meeting_id"]},{participant.Rows[0]["User_id"]})");
                }    


                DialogResult = DialogResult.OK;

            }

        }

        private void tbRequired_TextChanged(object sender, EventArgs e)
        {
            string input = tbRequired.Text;
            string suggestedEmail = GetSuggestedEmail(input);

            if (suggestedEmail != "")
            {
                lb.BackColor = Color.Transparent;
                lb.ForeColor = Color.Green;
                lb.Location = new Point(tbRequired.Left, tbRequired.Top + 24);
                lb.AutoSize = true;
                lb.Text = suggestedEmail;
                lb.Visible = true;
                lb.BringToFront();
            }
            else
            {
                lb.Visible = false;
            }
        }

        private void tbRequired_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string originalString = tbRequired.Text;
                int index = originalString.LastIndexOf(';');
                string text = "";
                if (index >= 0)
                {
                    text = originalString.Substring(0, index + 1);

                }
                string suggestedEmail = GetSuggestedEmail(tbRequired.Text);
                if (!string.IsNullOrEmpty(suggestedEmail))
                {
                    tbRequired.Text = text + suggestedEmail + ";";
                    // Di chuyển con trỏ văn bản đến cuối TextBox
                    tbRequired.SelectionStart = tbRequired.Text.Length;
                }
            }
        }

        private string GetSuggestedEmail(string input)
        {

            string suggestedEmail = "";
            string[] emailArray = input.Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (emailArray.Length > 0)
            {
                string lastEmail = emailArray[emailArray.Length - 1];
                DataTable data = SQLHandler.Instance.GetData($"SELECT TOP 1 User_email FROM Users WHERE User_email LIKE '{lastEmail}%'");

                if (data.Rows.Count > 0)
                {
                    suggestedEmail = data.Rows[0]["User_email"].ToString().Trim();
                }
            }

            return suggestedEmail;
        }


    }
}
