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
            lbStartDate.Text="Created " + taskdata.Rows[0]["Task_start_time"].ToString().Trim();
        }
    }
}
