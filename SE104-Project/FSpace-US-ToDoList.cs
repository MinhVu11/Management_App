using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SE104_Project
{
    public partial class FSpace_US_List : UserControl
    {
        private int spaceid;
        
        public int Spaceid
        {
            get
            {
                return spaceid;
            }
            set
            {
                spaceid = value;
            }
        }
        public FSpace_US_List()
        {
            InitializeComponent();
            dgvTodoList.AutoGenerateColumns = false;
        }

        private void FSpace_US_List_Load(object sender, EventArgs e)
        {
            LoadTaskList();
        }
        private void LoadTaskList()
        {
            DataTable tasklist = SQLHandler.Instance.GetData($"SELECT  Task.* from Task, Task_Space WHERE Task.Task_id = Task_Space.Task_id AND Space_id = {spaceid}");
            dgvTodoList.DataSource= tasklist;

            DataGridViewColumn taskIDColumn = new DataGridViewTextBoxColumn();
            taskIDColumn.DataPropertyName = "Task_id";
            taskIDColumn.Name = "TaskID";
            
            dgvTodoList.Columns.Add(taskIDColumn);
            taskIDColumn.Visible = false; // Ẩn cột TaskID

            DataGridViewColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Task_name";
            nameColumn.HeaderText = "Name";
            dgvTodoList.Columns.Add(nameColumn);

            DataGridViewColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.DataPropertyName = "Task_description";
            descriptionColumn.HeaderText = "Description";
            dgvTodoList.Columns.Add(descriptionColumn);

            DataGridViewColumn endTimeColumn = new DataGridViewTextBoxColumn();
            endTimeColumn.DataPropertyName = "Task_end_time";
            endTimeColumn.HeaderText = "Dua Date";
            dgvTodoList.Columns.Add(endTimeColumn);

            DataGridViewColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.DataPropertyName = "Task_status";
            statusColumn.HeaderText = "Status";
            dgvTodoList.Columns.Add(statusColumn);

        }

        private void dgvTodoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTodoList.Rows[e.RowIndex];
                FEditTask f = new FEditTask(Convert.ToInt32(dgvTodoList.Rows[e.RowIndex].Cells["TaskID"].Value)); 
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadTaskList();
                }
            }
        }
    }
}
