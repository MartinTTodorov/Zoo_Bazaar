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
    }
}
