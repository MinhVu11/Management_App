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
    public partial class FEditTask : Form
    {
        private int taskid;
        public FEditTask(int taskid)
        {
            InitializeComponent();
            this.taskid = taskid;           
        }

        private void FEditTask_Load(object sender, EventArgs e)
        {
            DataTable taskdata = SQLHandler.Instance.GetData($"SElect * from task where task_id={taskid}");
            DateTime datestart = (DateTime)taskdata.Rows[0]["Task_start_time"];
            lbStartDate.Text = "Created " + datestart.ToString("MMM d, HH:mm"); 
            tbTaskName.Text = taskdata.Rows[0]["Task_name"].ToString().Trim();
            rTBTaskDescription.Text = taskdata.Rows[0]["Task_description"].ToString().Trim();
            cBStatus.SelectedItem = $"{ taskdata.Rows[0]["Task_status"].ToString().Trim()}";
            DataTable moveto = SQLHandler.Instance.GetData($"Select * from Space,Workspace_Space where Workspace_Space.space_id=space.Space_id and Workspace_Space.workspace_id={FWorkspace.Workspace_id}");
            cbMoveto.DataSource = moveto;
            
            cbMoveto.DisplayMember = "Space_name";
            DataTable where = SQLHandler.Instance.GetData($"Select space.* from space,task_space where task_space.space_id=space.space_id and task_space.task_id={taskid}");
            if(where.Rows.Count>0)
            {
                string selectedSpaceName = where.Rows[0]["Space_name"].ToString().Trim();
                int selectedIndex = cbMoveto.FindString(selectedSpaceName); 
                cbMoveto.SelectedIndex = selectedIndex;

            }    
            

            DataTable assignment = SQLHandler.Instance.GetData($"Select Users.* from users,assignment where users.user_id=assignment.user_id and assignment.task_id={taskid}");
            lBPeopleList.DataSource = assignment;
            lBPeopleList.DisplayMember = "User_name";
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            FShareTask f=new FShareTask(taskid);
            f.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbTaskName.Text == "")
            {
                MessageBox.Show("Please enter Your Task Name");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Update Task set task_name='{tbTaskName.Text}',task_description= '{rTBTaskDescription.Text}', task_status='{cBStatus.Text}',task_end_time= '{dTPEndDate.Value}' where task_id={taskid} ");

                SQLHandler.Instance.ExcuteNonQuery($"Delete from task_space where task_id={taskid}");
                DataRowView cbmoveto = (DataRowView)cbMoveto.SelectedValue;
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task_Space(Task_id, Space_id) values ({taskid},{cbmoveto["Space_id"]})");

                SQLHandler.Instance.ExcuteNonQuery($"Delete from Assignment where task_id={taskid}");
                foreach (object item in lBPeopleList.Items)
                {
                    DataRowView row = (DataRowView)item;
                  
                    int id = Convert.ToInt32(row["user_id"]);
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Assignment( Task_id, User_id) values ({taskid},{id})");

                }

                Close();
            }
        }
    }
}
