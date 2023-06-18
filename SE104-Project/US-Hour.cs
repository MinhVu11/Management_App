using System.Windows.Forms;

namespace SE104_Project
{
    public partial class US_Hour : UserControl
    {
        public US_Hour()
        {
            InitializeComponent();
        }
        public void SetHour(int hour)
        {
            lbHour.Text = hour.ToString() + ":00";
        }
        public void displayEvent(Event ev)
        {
            Label deadline = new Label();
            deadline.Text = $"Duedate of{ev.Name}in {ev.Enddate}";
            flpEvents.Controls.Add(deadline);
        }
    }
}
