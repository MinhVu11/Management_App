using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FHome : Form
    {
        private int user_id;
        private List<Event> events;
        private DataTable tasklist;
        private DataTable meetinglist;

        public FHome(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            monthCalendar.BringToFront();

        }

        private void FHome_Load(object sender, System.EventArgs e)
        {
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[DateTime.Now.Month];
            string dayname = DateTime.Now.DayOfWeek.ToString();
            lbDay.Text = monthname + " " + DateTime.Now.Day + ", " + dayname;
            events = Event.GetEventsFromUserId(user_id);
            loadcalendar(DateTime.Now);

            loadTaskintoDGV();

        }
        private void loadTaskintoDGV()
        {
            dgv.Columns.Clear();
            tasklist = SQLHandler.Instance.GetData($"SELECT  Task.* from Task, Assignment WHERE Task.Task_id = Assignment.Task_id AND User_id={user_id} ");

            dgv.AutoGenerateColumns = false;
            tasklist.TableName = "tasklist";
            dgv.DataSource = tasklist;
            

            DataGridViewColumn taskIDColumn = new DataGridViewTextBoxColumn();
            taskIDColumn.DataPropertyName = "Task_id";
            taskIDColumn.Name = "TaskID";

            dgv.Columns.Add(taskIDColumn);
            taskIDColumn.Visible = false; // Ẩn cột TaskID

            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Task_name";
            nameColumn.HeaderText = "Name";
            dgv.Columns.Add(nameColumn);

            DataGridViewColumn startTimeColumn = new DataGridViewTextBoxColumn();
            startTimeColumn.DataPropertyName = "Task_start_time";
            startTimeColumn.HeaderText = "Start time";
            dgv.Columns.Add(startTimeColumn);

            DataGridViewColumn endTimeColumn = new DataGridViewTextBoxColumn();
            endTimeColumn.DataPropertyName = "Task_end_time";
            endTimeColumn.HeaderText = "Dua Date";
            dgv.Columns.Add(endTimeColumn);

            DataGridViewColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.DataPropertyName = "Task_status";
            statusColumn.HeaderText = "Status";
            dgv.Columns.Add(statusColumn);
        }
        private void loadMeetingintoDGV()
        {
            dgv.Columns.Clear();
            meetinglist = SQLHandler.Instance.GetData($"Select Meeting.* from meeting,participants where meeting.meeting_id=participants.Meeting_id and participants.user_id={user_id}");
            dgv.AutoGenerateColumns = true;
            meetinglist.TableName = "meetinglist";
            dgv.DataSource = meetinglist;
        }


        private void lbDay_Click(object sender, EventArgs e)
        {
            if (monthCalendar.Visible == false)
            {
                monthCalendar.Show();
            }
            else
            {
                monthCalendar.Hide();
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;

            string monthname = selectedDate.ToString("MMMM");
            string dayname = selectedDate.DayOfWeek.ToString();

            lbDay.Text = monthname + " " + selectedDate.Day + ", " + dayname;
            loadcalendar(selectedDate);
        }
        private void loadcalendar(DateTime dt)
        {
            if (flpCalendar.Controls.Count > 0)
            {
                flpCalendar.Controls.Clear();
            }
            for (int i = 0; i < 24; i++)
            {
                US_Hour hour = new US_Hour();
                hour.SetHour(i);
                foreach (Event item in events)
                {
                    if (dt.Day == item.Enddate.Day && dt.Month == item.Enddate.Month && dt.Year == item.Enddate.Year && i == item.Enddate.Hour)
                    {
                        hour.displayEvent(item);
                        break;
                    }
                }
                flpCalendar.Controls.Add(hour);

            }
        }

        private void pnCalendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(-1);
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            loadTaskintoDGV();
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            loadMeetingintoDGV();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable data = (DataTable)dgv.DataSource;
            if (data.TableName == "meetinglist")
            {

            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgv.Rows[e.RowIndex];
                    FEditTask f = new FEditTask(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["TaskID"].Value));
                    if (f.ShowDialog() == DialogResult.OK)
                    {

                    }
                }

            }


        }


        private void btnShared_Click(object sender, EventArgs e)
        {
            dgv.Columns.Clear();
            DataTable sharedTask = SQLHandler.Instance.GetData($"SElect Task.* from Task,ShareTask where Task.task_id=ShareTAsk.Task_id and user_id={user_id}");
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = sharedTask;

            DataGridViewColumn taskIDColumn = new DataGridViewTextBoxColumn();
            taskIDColumn.DataPropertyName = "Task_id";
            taskIDColumn.Name = "TaskID";

            dgv.Columns.Add(taskIDColumn);
            taskIDColumn.Visible = false; // Ẩn cột TaskID

            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Task_name";
            nameColumn.HeaderText = "Name";
            dgv.Columns.Add(nameColumn);

            DataGridViewColumn startTimeColumn = new DataGridViewTextBoxColumn();
            startTimeColumn.DataPropertyName = "Task_start_time";
            startTimeColumn.HeaderText = "Start time";
            dgv.Columns.Add(startTimeColumn);

            DataGridViewColumn endTimeColumn = new DataGridViewTextBoxColumn();
            endTimeColumn.DataPropertyName = "Task_end_time";
            endTimeColumn.HeaderText = "Dua Date";
            dgv.Columns.Add(endTimeColumn);

            DataGridViewColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.DataPropertyName = "Task_status";
            statusColumn.HeaderText = "Status";
            dgv.Columns.Add(statusColumn);

        }
    }
}
