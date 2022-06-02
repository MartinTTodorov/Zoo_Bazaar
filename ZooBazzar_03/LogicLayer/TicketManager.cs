using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class TicketManager
    {
        private List<Ticket> tickets;
        ITicketDB db;
        public TicketManager(ITicketDB db)
        {
            this.db = db;
            tickets = db.GetTickets();
        }

        public Ticket GetTicket(int id)
        {
            return tickets.Find(x=> x.Id == id);
        }

        public List<Ticket> GetTickets(Customer c)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (Ticket t in this.tickets)
            {
                if (t.Customer.Id == c.Id)
                {
                    tickets.Add(t);
                }
            }
            return tickets;
        }
        public Customer GetCustomer(string email)
        {
           return db.GetCustomer(email);
        }
        public bool ChangeTicketStatus(Ticket t)
        {
            if (t.IsUsed == true)
            {
                return false;
            }
            db.ChangeTicketStatus(t);
            return true;
        }
    }
}
