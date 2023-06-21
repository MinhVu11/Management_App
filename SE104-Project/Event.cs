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
                DateTime s = Convert.ToDateTime(row["Task_start_time"]);
                DateTime e = Convert.ToDateTime(row["Task_end_time"]);
                Event item= new Event(n, s, e);
                events.Add(item);
            }
        
            return events;
        }
        public static List<Event> GetEventsFromUserId(int userid)
        {
            List<Event> events = new List<Event>();

            // get task
            DataTable taskdata = SQLHandler.Instance.GetData($"SELECT  Task.* from Task, Assignment WHERE Task.Task_id = Assignment.Task_id AND User_id = {userid}");
            foreach (DataRow row in taskdata.Rows)
            {
                string n = row["Task_name"].ToString().Trim();
                DateTime s = Convert.ToDateTime(row["Task_start_time"]);
                DateTime e = Convert.ToDateTime(row["Task_end_time"]);
                Event item = new Event(n, s, e);
                events.Add(item);
            }
            // get meeting
            DataTable meetingdata = SQLHandler.Instance.GetData($"Select Meeting.* from meeting,participants where meeting.workspace_id={FWorkspace.Workspace_id} and meeting.meeting_id=participants.meeting_id and participants.User_id={userid}");
            foreach (DataRow row in meetingdata.Rows)
            {
                string n = row["meeting_name"].ToString().Trim();
                DateTime s = Convert.ToDateTime(row["Meeting_start_time"]);
                DateTime e = Convert.ToDateTime(row["Meeting_end_time"]);
                Event item = new Event(n, s, e);
                events.Add(item);
            }
            return events;
        }
        public static List<Event> GetEventsFromWorkspaceid(int workspaceid)
        {
            List<Event> events = new List<Event>();

            // get task
            DataTable taskdata = SQLHandler.Instance.GetData($"select task.* from task,task_space,workspace_space where task.task_id=task_space.task_id and task_space.space_id = workspace_space.space_id and workspace_space.workspace_id={FWorkspace.Workspace_id}");
            foreach (DataRow row in taskdata.Rows)
            {
                string n = row["Task_name"].ToString().Trim();
                DateTime s = Convert.ToDateTime(row["Task_start_time"]);
                DateTime e = Convert.ToDateTime(row["Task_end_time"]);
                Event item = new Event(n, s, e);
                events.Add(item);
            }
            // get meeting

            DataTable meetingdata = SQLHandler.Instance.GetData($"Select Meeting.* from meeting where meeting.workspace_id={FWorkspace.Workspace_id}");
            foreach (DataRow row in meetingdata.Rows)
            {
                string n = row["meeting_name"].ToString().Trim();
                DateTime s = Convert.ToDateTime(row["Meeting_start_time"]);
                DateTime e = Convert.ToDateTime(row["Meeting_end_time"]);
                Event item = new Event(n, s, e);
                events.Add(item);
            }
            return events;
        }
        
    }
}
