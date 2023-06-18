using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_Calendar : UserControl
    {
        private int month, year;
        private List<Event> events;
        public US_Calendar(int spaceid)
        {
            InitializeComponent();
            this.events = Event.GetEventsFromSpaceId(spaceid);
            
        }
        public US_Calendar()
        {
            InitializeComponent();
            this.events = Event.GetEventsFromWorkspaceid(FWorkspace.Workspace_id);
        }
      
        private void FSpace_US_Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;

            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                US_Blank usblank = new US_Blank();
                flpDays.Controls.Add(usblank);
            }
            for (int i = 1; i <= days; i++)
            {
                US_Days usday = new US_Days();
                usday.days(i);
                foreach (Event item in events)
                {                  
                    if(i== item.Enddate.Day && month == item.Enddate.Month && year == item.Enddate.Year)
                    {
                        usday.displayEvent(item);
                        break;
                    }    
                }    
                flpDays.Controls.Add(usday);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            flpDays.Controls.Clear();
            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                US_Blank usblank = new US_Blank();
                flpDays.Controls.Add(usblank);
            }
            for (int i = 1; i <= days; i++)
            {
                US_Days usday = new US_Days();
                usday.days(i);
                foreach (Event item in events)
                {
                    if (i == item.Enddate.Day && month == item.Enddate.Month && year == item.Enddate.Year)
                    {
                        usday.displayEvent(item);
                        break;
                    }
                }
                flpDays.Controls.Add(usday);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flpDays.Controls.Clear();
            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname + " " + year;
            DateTime startofmonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayofweek; i++)
            {
                US_Blank usblank = new US_Blank();
                flpDays.Controls.Add(usblank);
            }
            for (int i = 1; i <= days; i++)
            {
                US_Days usday = new US_Days();
                usday.days(i);
                foreach (Event item in events)
                {
                    if (i == item.Enddate.Day && month == item.Enddate.Month && year == item.Enddate.Year)
                    {
                        usday.displayEvent(item);
                        break;
                    }
                }
                flpDays.Controls.Add(usday);
            }
        }
        
    }
}
