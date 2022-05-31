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

        public Dictionary<int, int> GetTicketSalesStatistics(string filter, string filter2)
        {
            return manager.GetTicketSales(filter, filter2);
        }

        public Dictionary<int, double> GetIncome(string filter)
        {
            return manager.GetIncome(filter);
        }
    }
}
