using System;
using System.Collections.Generic;
using System.Data;

namespace SE104_Project
{
    public class Event
    {
        private string name;
        private DateTime stardate;
        private DateTime enddate;

        public Event(string name, DateTime stardate, DateTime enddate)
        {
            this.name = name;
            this.stardate = stardate;
            this.enddate = enddate;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Stardate
        {
            get { return stardate; }
            set { stardate = value; }
        }
        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

        public static List<Event> GetEventsFromSpaceId(int spaceid)
        {
            List<Event> events = new List<Event>();
            // get task
            DataTable taskdata = SQLHandler.Instance.GetData($"SELECT  Task.* from Task, Task_Space WHERE Task.Task_id = Task_Space.Task_id AND Space_id = {spaceid}");
            foreach (DataRow row in taskdata.Rows)
            {
                string n = row["Task_name"].ToString().Trim();
                DateTime s = Convert.ToDateTime(row["Task_start_date"]);
                DateTime e = Convert.ToDateTime(row["Task_end_date"]);
                Event item= new Event(n, s, e);
                events.Add(item);
            }
            // get meeting

            return events;
        }
    }
}
