using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subscription
    {
        //Fields
        private int id;
        private DateTime startDate;
        private DateTime endDate;
        private TypeSubscription subscription;

        public int Id { get { return id; } }
        public DateTime StartDate
        {
            get { return startDate; }
            private set
            {
                if (value.Date >= DateTime.Now.Date)
                {
                    startDate = value;
                }
                else
                {
                    throw new Exception("The start date should not be past date");
                }
            }
        }
        public DateTime EndDate { get { return endDate; } }
        public TypeSubscription SubscriptionType { get { return subscription; } }

        public Subscription(DateTime startDate, TypeSubscription type)
        {
            this.StartDate = startDate;
            this.subscription = type;
            this.endDate = type.CalculateEndDate(StartDate);
        }

        public Subscription(int id, DateTime startDate, DateTime endDate, TypeSubscription subscription)
        {
            this.id = id;
            this.startDate = startDate;
            this.subscription = subscription;
            this.endDate = endDate;
        }
    }
}
