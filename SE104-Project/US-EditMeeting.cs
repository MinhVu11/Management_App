using System;
using System.Data;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_EditMeeting : UserControl
    {
        private int meeting_id;
        public US_EditMeeting(int id)
        {
            InitializeComponent();
            this.meeting_id = id;
        }

        private void FMeeting_US_Meeting_Load(object sender, EventArgs e)
        {
            DataTable meetingdata = SQLHandler.Instance.GetData($"Select * from Meeting where Meeting_id={meeting_id}");
            DataTable organizer = SQLHandler.Instance.GetData($"Select * from Users where User_id={Convert.ToInt32(meetingdata.Rows[0]["Organizer_id"])}");
            tbOrganizer.Text = organizer.Rows[0]["User_email"].ToString().Trim();
            tbTitle.Text = meetingdata.Rows[0]["meeting_name"].ToString().Trim();
            dtpStarttime.Value = ((DateTime)meetingdata.Rows[0]["Meeting_start_time"]).Date;
            cbStart.SelectedItem = $"{((DateTime)meetingdata.Rows[0]["Meeting_start_time"]).Hour}:{((DateTime)meetingdata.Rows[0]["Meeting_start_time"]).Minute.ToString("D2")}";
            dtpEndtime.Value = ((DateTime)meetingdata.Rows[0]["Meeting_end_time"]).Date;
            cbEnd.SelectedItem = $"{((DateTime)meetingdata.Rows[0]["Meeting_end_time"]).Hour}:{((DateTime)meetingdata.Rows[0]["Meeting_end_time"]).Minute.ToString("D2")}";
            tbDesciption.Text = meetingdata.Rows[0]["Meeting_description"].ToString().Trim();

            tbRequired.Text = "";
            DataTable participant = SQLHandler.Instance.GetData($"Select users.* from participants,users where meeting_id={meeting_id} and users.User_id=Participants.User_id");
            foreach (DataRow row in participant.Rows)
            {
                tbRequired.Text += row["User_email"].ToString().Trim() + ';';
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                MessageBox.Show("Please enter tilte");
            }
            else
            {
                string check;
                if (cbCheck.Checked)
                {
                    check = "checked";
                }
                else
                {
                    check = "unchecked";
                }
                DateTime starttime = dtpStarttime.Value.Date.Add(TimeSpan.Parse(cbStart.SelectedItem.ToString()));
                DateTime endtime = dtpEndtime.Value.Date.Add(TimeSpan.Parse(cbEnd.SelectedItem.ToString()));
                SQLHandler.Instance.ExcuteNonQuery($"Update Meeting set Organizer_id={FWorkspace.User_id},Meeting_name='{tbTitle.Text}',Meeting_Start_time='{starttime}',Meeting_end_time='{endtime}',Meeting_description='{tbDesciption.Text}',Meeting_status='{check}' where Meeting_id={meeting_id}");
                DataTable meeting = SQLHandler.Instance.GetData("SELECT TOP 1 * FROM meeting ORDER BY Meeting_id DESC");

                SQLHandler.Instance.ExcuteNonQuery($"Delete from participants where Meeting_id={meeting_id}");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Participants values({meeting.Rows[0]["meeting_id"]},{meeting.Rows[0]["Organizer_id"]})");
                string[] strings = tbRequired.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in strings)
                {
                    DataTable participant = SQLHandler.Instance.GetData($"Select * from Users where User_email='{str}'");
                    if (Convert.ToInt32(meeting.Rows[0]["Organizer_id"]) != Convert.ToInt32(participant.Rows[0]["User_id"]))
                    {
                        SQLHandler.Instance.ExcuteNonQuery($"Insert into Participants values({meeting.Rows[0]["Meeting_id"]},{participant.Rows[0]["User_id"]})");

                    }
                }

            }
        }
    }
}
