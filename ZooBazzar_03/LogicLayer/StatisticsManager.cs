using Entities;

namespace LogicLayer
{
    public class StatisticsManager
    {

        private IStatistics manager;

        public StatisticsManager(IStatistics manager)
        {
            this.manager = manager;
        }

        public Dictionary<int, int> GetTicketSalesStatistics(string filter, string place, string filter2, int value)
        {
            return manager.GetTicketSales(filter, place, filter2, value);
        }

        public Dictionary<int, double> GetIncome(string filter, string filter2, int value)
        {
            return manager.GetIncome(filter, filter2, value);
        }
    }
}
