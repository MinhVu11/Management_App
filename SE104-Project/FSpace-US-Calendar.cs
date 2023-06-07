using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSpace_US_Calendar : UserControl
    {
        private int month,year;
        private int spaceid;
        public FSpace_US_Calendar(int spaceid)
        {
            InitializeComponent();
            this.spaceid = spaceid;
        }

        private void FSpace_US_Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

       

        private void displayDays()
        {
            DateTime now= DateTime.Now;
            month=now.Month;
            year=now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.MonthNames[month];
            lbDate.Text = monthname+" "+year;

            DateTime startofmonth = new DateTime(year, month,1);
            int days=DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d"))+1;
            for (int i=1;i<dayofweek;i++) 
            {
                US_Blank usblank=new US_Blank();
                flpDays.Controls.Add(usblank);
            }
            for (int i = 1; i <=days; i++)
            {
                US_Days usday = new US_Days();
                usday.days(i);
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
                flpDays.Controls.Add(usday);
            }
        }
        private List<Event> handlerEvent()
        {
            List<Event> eventlist = Event.GetEventsFromSpaceId(spaceid);
            return eventlist;
        }
    }
}
