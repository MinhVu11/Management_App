using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE104_Project
{
    public class Workspace
    {
        private int workspace_id;
        private string workspace_name;
        public Workspace(int id,string name)
        {
            this.workspace_id = id;
            this.workspace_name = name; 
        }
        public int Workspace_id
        {
            get { return workspace_id; }
            set { workspace_id = value; }
        }
        public string Workspace_name
        {
            get { return workspace_name; }
            set { workspace_name = value; }
        }
    }
}
