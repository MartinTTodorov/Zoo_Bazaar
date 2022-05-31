using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ticket
    {
        //Fields
        private int id;
        private Customer customer;
        private TypeOfTicket typeOfTicket;
        private DateTime? date;
        private DateTime dateOfPurchase;
        private bool isUsed;

        public int Id { get { return id; } }
        public Customer Customer
        {
            get { return customer; }
            private set
            {
                if (value != null)
                {
                    customer = value;
                }
            }
        }
        public TypeOfTicket TypeOfTicket
        {
            get { return typeOfTicket; }
            private set
            {
                if (Enum.IsDefined(typeof(TypeOfTicket), value))
                {
                    typeOfTicket = value;
                }
            }
        }
        public DateTime? Date { get { return date; } private set
            {
                if(value >= DateTime.UtcNow)
                {
                    date = value;
                }
            }
        }

        //Constructor
        public Ticket(int id, Customer customer, TypeOfTicket typeOfTicket, DateTime date, DateTime dateOfPurchase)
        {
            this.id = id;
            this.customer = customer;
            this.typeOfTicket = typeOfTicket;
            this.date = date;
            this.dateOfPurchase = dateOfPurchase;
            this.isUsed = false;
            this.dateOfPurchase = DateTime.UtcNow;
        }

        //Method
        public override string ToString()
        {
            return $"{customer}: {date} : {isUsed}";
        }

        public void UseTicket()
        {
            this.isUsed = true;
        }

    }
}
