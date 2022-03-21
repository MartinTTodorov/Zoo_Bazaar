using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03
{
    public partial class Date : UserControl
    {
        public Date()
        {
            InitializeComponent();
        }

        private void Date_Load(object sender, EventArgs e)
        {
            
        }

        public void GetDate(string weekday, string date)
        {
            lblWeekDay.Text = weekday;
            lblDate.Text = date;
        }

        private void Date_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.ShowDialog();
        }
    }
}
