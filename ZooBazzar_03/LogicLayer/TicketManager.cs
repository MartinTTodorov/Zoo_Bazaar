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
        public IList<Ticket> Tickets { get { return tickets.AsReadOnly(); } }

        public TicketManager()
        {
            tickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void UpdateTicket(int id)
        {
            tickets.Find(t => t.Id == id).UseTicket();
        }
    }
}
