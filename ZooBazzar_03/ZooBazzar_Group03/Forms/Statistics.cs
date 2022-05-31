using System.Windows.Forms.DataVisualization.Charting;
using Entities;
using DataAccessLayer;
using LogicLayer;

namespace ZooBazzar_Group03.Forms
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        StatisticsManager sm = new StatisticsManager(new StatisticsDB());

        private void btnGetStatistics_Click(object sender, EventArgs e)
        {
            panelStatistics.Controls.Clear();

            Chart myChart = new Chart();
            myChart.Dock = DockStyle.Fill;


            ticketSales = sm.GetTicketSalesStatistics(filter, "zoo");
            onlineTicketSales = sm.GetTicketSalesStatistics(filter, "online");

            myChart.ChartAreas.Add(new ChartArea());

            myChart.Series.Add(name: "Tickets bought at the zoo");
            myChart.Series.Add(name: "Tickets bought online");
            myChart.Legends.Add(name: "Tickets");
            myChart.ChartAreas[0].AxisX.Title = filter;
            myChart.ChartAreas[0].AxisY.Title = "Number of tickets";

            for (int i = 0; i < ticketSales.Count; i++)
            {
                var item = ticketSales.ElementAt(i);
                myChart.Series[0].Points.AddXY(item.Key, item.Value);
            }

            for (int i = 0; i < onlineTicketSales.Count; i++)
            {
                var item = onlineTicketSales.ElementAt(i);
                myChart.Series[1].Points.AddXY(item.Key, item.Value);
            }

            panelStatistics.Controls.Add(myChart);


        }


        private string filter;
        private Dictionary<int, int> ticketSales;
        private Dictionary<int, int> onlineTicketSales;

        private Dictionary<int, double> income;

        private void rbYearlyStats_CheckedChanged(object sender, EventArgs e)
        {
            filter = "YEAR";
        }

        private void rbMonthlyStats_CheckedChanged(object sender, EventArgs e)
        {
            filter = "MONTH";
        }

        private void rbWeeklyStats_CheckedChanged(object sender, EventArgs e)
        {
            filter = "WEEK";
        }

        private void btnGetIncome_Click(object sender, EventArgs e)
        {
            panelStatistics.Controls.Clear();

            Chart myChart = new Chart();
            myChart.Dock = DockStyle.Fill;

            income = sm.GetIncome(filter);

            myChart.ChartAreas.Add(new ChartArea());

            myChart.Series.Add(name: "Income of the zoo in euro");
            myChart.Series[0].ChartType = SeriesChartType.Line;
            myChart.Legends.Add(name: "Income");
            myChart.ChartAreas[0].AxisX.Title = filter;
            myChart.ChartAreas[0].AxisY.Title = "Income in euros";

            for (int i = 0; i < income.Count; i++)
            {
                var item = income.ElementAt(i);
                myChart.Series[0].Points.AddXY(item.Key, item.Value);
            }

            panelStatistics.Controls.Add(myChart);
        }


    }
}
