using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SE104_Project
{
    public class Space
    {
        private int space_id;
        private string space_name;
        private string space_type;
        public Space(int space_id, string space_name, string space_type)
        {
            this.space_id = space_id;
            this.space_name = space_name;
            this.space_type = space_type;
        }   
        public int Space_id
        {
            get { return space_id; }
            set { space_id= value; }
        }
        public string Space_name
        {
            get { return space_name; }
            set { space_name= value; }
        }
        public string Space_type
        {
            get { return space_type; }
            set { space_type = value; }
        }
        public static List<Space> GetPublicSpace()
        {
            List<Space> Spacepublic = new List<Space>();
            DataTable data=new DataTable();
            data = SQLHandler.Instance.GetData($"Select * from Workspace_Space,Space where Workspace_Space.Space_id=Space.Space_id and Workspace_id={FWorkspace.Workspace_id} and Space.Space_type='public'");
            foreach(DataRow item in data.Rows)
            {
                int id = (int)item["Space_id"];
                string name = item["Space_name"].ToString();
                string type = item["Space_type"].ToString();
                Space space= new Space(id, name, type);
                Spacepublic.Add(space);
            }
            return Spacepublic;
        }
        public static List<Space> GetPrivateSpace()
        {
            List<Space> Spaceprivate = new List<Space>();
            DataTable data = new DataTable();
            data = SQLHandler.Instance.GetData($"Select Space.* from Space,Groups,Group_Member,Workspace_Space where Workspace_Space.Space_id=Space.Space_id and Groups.Group_id= Group_Member.Group_id and Workspace_Space.Space_id=Space.Space_id and Groups.Space_id=Space.Space_id and Workspace_Space.Workspace_id={FWorkspace.Workspace_id} and Space.Space_type='private' and Group_Member.User_id={FWorkspace.User_id} ");
            foreach (DataRow item in data.Rows)
            {
                int id = (int)item["Space_id"];
                string name = item["Space_name"].ToString();
                string type = item["Space_type"].ToString();
                Space space = new Space(id, name, type);
                Spaceprivate.Add(space);
            }
            return Spaceprivate;
        }
    }
}
