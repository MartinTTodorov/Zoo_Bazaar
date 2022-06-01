using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ticket
    {
        //fields
        private int id;
        private Customer customer;
        private TypeOfTicket typeOfTicket;
       // private DateTime? date;
        private DateTime dateOfPurchase;
        private string placeOfPurchase;

        //Properties

        public int Id { get { return this.id; } }
        public Customer Customer { get { return this.customer; } }
        public TypeOfTicket TypeOfTicket { get { return this.typeOfTicket; } }
      //  public DateTime? Date { get { return this.date; } }
        public DateTime DateOfPurchase { get { return this.dateOfPurchase; } }
        public string PlaceOfPurchase { get { return this.placeOfPurchase; } }

        public Ticket(int id, Customer customer, TypeOfTicket typeOfTicket, DateTime dateOfPurchase, string placeOfPurchase)
        {
            this.id = id;
            this.customer = customer;   
            this.typeOfTicket = typeOfTicket;
           // this.date = date;
            this.dateOfPurchase = dateOfPurchase;
            this.placeOfPurchase = placeOfPurchase;

        }

        public override string ToString()
        {
            return $"{Customer.FirstName} {Customer.LastName} {TypeOfTicket} " ;
        }
    }
}
