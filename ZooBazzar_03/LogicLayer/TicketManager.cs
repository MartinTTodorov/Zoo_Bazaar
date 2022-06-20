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
        //Fields
        private ICRU<Ticket> crud;
        private IAutoIncrementable auto;
        private List<Ticket> tickets;
        public IList<Ticket> Tickets { get { return tickets.AsReadOnly(); } }

        //Constructor
        public TicketManager(ICRU<Ticket>crud,IAutoIncrementable auto)
        {
            this.auto = auto;
            this.crud = crud;
            tickets = crud.Read();
        }

        //Methods
        public void AddTicket(Ticket ticket)
        {
            Ticket temp = new Ticket(auto.GetNexID(),ticket.Customer,ticket.TypeOfTicket,ticket.Date,ticket.PlaceOfPerchase,ticket.Price);
            tickets.Add(temp);
            crud.Add(temp);
        }

        public void UseTicket(int id)
        {
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Id == id)
                {
                    tickets[i].UseTicket();
                    crud.Update(tickets[i]);
                }
            }
            
        }

        public void Update(Ticket ticket)
        {
            crud.Update(ticket);
            for (int i = 0; i < tickets.Count; i++)
            {
                if(tickets[i].Id == ticket.Id)
                {
                    tickets[i] = ticket;
                }
            }
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

        public Ticket GetTicket(int id)
        {
            return tickets.Find(x => x.Id == id);
        }
        public bool ChangeTicketStatus(Ticket t)
        {
            if (t.IsUsed == true)
            {
                return false;
            }
            crud.Update(t);
            return true;
        }

      
    }
}
