﻿using System.Windows.Forms.DataVisualization.Charting;
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
            myChart.ChartAreas.Add(new ChartArea());

            if (filter2 == "MONTH")
            {
                ticketSales = sm.GetTicketSalesStatistics(filter, "zoo", filter2, date.Month);
                onlineTicketSales = sm.GetTicketSalesStatistics(filter, "online", filter2, date.Month);
                myChart.ChartAreas[0].AxisX.Title = date.ToString("MMMM"); 
            }
            else if (filter2 == "YEAR")
            {
                ticketSales = sm.GetTicketSalesStatistics(filter, "zoo", filter2, date.Year);
                onlineTicketSales = sm.GetTicketSalesStatistics(filter, "online", filter2, date.Year);
                myChart.ChartAreas[0].AxisX.Title = date.ToString("yyyy");
            }
            else
            {
                ticketSales = sm.GetTicketSalesStatistics(filter, "zoo", null, 0);
                onlineTicketSales = sm.GetTicketSalesStatistics(filter, "online", null, 0);
                myChart.ChartAreas[0].AxisX.Title = filter;
            }


            ticketSales = sm.GetTicketSalesStatistics(filter, "zoo", filter2, date.Month);
            onlineTicketSales = sm.GetTicketSalesStatistics(filter, "online", filter2, date.Month);

            

            myChart.Series.Add(name: "Tickets bought at the zoo");
            myChart.Series.Add(name: "Tickets bought online");
            myChart.Legends.Add(name: "Tickets");

           
            
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
        private string filter2;
        DateTime date;
        private Dictionary<int, int> ticketSales;
        private Dictionary<int, int> onlineTicketSales;

        private Dictionary<int, double> income;

        private void rbYearlyStats_CheckedChanged(object sender, EventArgs e)
        {
            filter = "YEAR";
            filter2 = null;
        }

        private void rbMonthlyStats_CheckedChanged(object sender, EventArgs e)
        {
            filter = "MONTH";
            filter2 = "YEAR";
        }

        private void rbWeeklyStats_CheckedChanged(object sender, EventArgs e)
        {
            filter = "WEEK";
            filter2 = "MONTH";
        }

        private void btnGetIncome_Click(object sender, EventArgs e)
        {
            panelStatistics.Controls.Clear();

            Chart myChart = new Chart();
            myChart.Dock = DockStyle.Fill;
            myChart.ChartAreas.Add(new ChartArea());

            if (filter2 == "MONTH")
            {
                income = sm.GetIncome(filter, filter2, date.Month);
                myChart.ChartAreas[0].AxisX.Title = date.ToString("MMMM");
            }
            else if (filter2 == "YEAR")
            {
                income = sm.GetIncome(filter, filter2, date.Year);
                myChart.ChartAreas[0].AxisX.Title = date.ToString("yyyy");
            }
            else
            {
                income = sm.GetIncome(filter, null, 0);
                myChart.ChartAreas[0].AxisX.Title = filter;
            }
            

            

            myChart.Series.Add(name: "Income of the zoo in euro");
            myChart.Series[0].ChartType = SeriesChartType.Line;
            myChart.Legends.Add(name: "Income");
            
            myChart.ChartAreas[0].AxisY.Title = "Income in euros";

            for (int i = 0; i < income.Count; i++)
            {
                var item = income.ElementAt(i);
                myChart.Series[0].Points.AddXY(item.Key, item.Value);
            }

            panelStatistics.Controls.Add(myChart);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            date = dtp.Value;
        }

        private void btnNrOfVisitors_Click(object sender, EventArgs e)
        {

        }
    }
}