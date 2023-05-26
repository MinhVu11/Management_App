using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FCreateTask : Form
    {

        private int chosen_User;
        public FCreateTask()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            // Load comboBox Danh sach Space
            DataTable Spaces_data = SQLHandler.Instance.GetData($"select * from Space, Workspace_Space, Space where Space.Space_id = Workspace_Space.Space_id and Workspace_Space.Workspace_id = {FWorkspace.Workspace_id} ");
            cBIn.DataSource = Spaces_data;
            cBIn.DisplayMember = "Space_name";
            cBIn.ValueMember = "Space_id";
            // Load Combo Box Add People
            int Selected_Space_id = (int)cBIn.SelectedItem;    
            DataTable User_data = SQLHandler.Instance.GetData($"select * from USers, Space, Space_User where {Selected_Space_id} = Space_Users.Space_id and Space_Users.User_id = Users.User_id ");
            cBAddPeople.DataSource = User_data;
            cBAddPeople.DisplayMember = "User_name";
            cBAddPeople.ValueMember = "User_id";
        }

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
            if (tbTaskName.Text == "")
            {
                MessageBox.Show("Please enter Your Task Name");
            }
            else
            {
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task(Task_name, Task_description, Task_status, Task_start time, Task_end_time) values('{tbTaskName.Text}', '{rTBTaskDescription.Text}', '{cBStatus.Text}', '{dTPStartDate.Text}', '{dTPEndDate.Text}' ) ");
                DataTable Task_Space_data = SQLHandler.Instance.GetData($"select TOP 1 * from Task_Space Order by Task_Space_id DESC");
                DataTable Task_data = SQLHandler.Instance.GetData($"select TOP 1 * from Task Order by Task_id DESC");
                SQLHandler.Instance.ExcuteNonQuery($"Insert into Task_Space(Task_Space_id, Task_id, Space_id) values ('{Task_Space_data.Rows[0]} + 1', '{Task_data.Rows[0]} + 1','{cBIn}')");

                foreach (object item in lBPeopleList.Items)
                {
                    DataTable Assignment_data = SQLHandler.Instance.GetData($"select TOP 1 * from Assignment Order by Assingment_id DESC");
                    SQLHandler.Instance.ExcuteNonQuery($"Insert into Assignment(Assignment_id, Task_id, User_id) values ('{Assignment_data.Rows[0]} + 1','{Task_Space_data.Rows[0]} + 1', '')");

                }
                Close();
            }
        }

        private void cBAddPeople_SelectionChangeCommitted(object sender, EventArgs e)
        {

            chosen_User = (int)cBAddPeople.SelectedItem;
            DataTable Chosen_User_Name = SQLHandler.Instance.GetData($"select USer_name from Users where Users.USer_id = {chosen_User}");
            lBPeopleList.Items.Add(Chosen_User_Name);
        }
    }
}
