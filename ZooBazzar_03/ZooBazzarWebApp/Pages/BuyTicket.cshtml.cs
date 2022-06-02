using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class BuyTicketModel : PageModel
    {
        [BindProperty]
        public TicketDTO Ticket{ get; set; }

        public CustomerManager cm = new CustomerManager(new CustomerDB());
        public TicketManager tm = new TicketManager(new TicketsDB(), new TicketsDB());
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                decimal price = 0;
                Customer customer = cm.GetCustomerByEmail(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value);
                if (Ticket.Type == TypeOfTicket.adult)
                {
                    price = 8;
                }
                else if (Ticket.Type == TypeOfTicket.child)
                {
                    price = 6;
                }
                Ticket ticket = new Ticket(customer, Ticket.Type, Ticket.Date, PlaceOfPerchase.online, price);
                tm.AddTicket(ticket);
                return RedirectToPage("MyTickets");

            }
            return Page();
        }
    }
}
