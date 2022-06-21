using DataAccessLayer;
using Entities;
using LogicLayer;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;
using MimeKit.Text;
using System.Net.Mail;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class BuyTicketModel : PageModel
    {
        [BindProperty]
        public TicketDTO Ticket { get; set; }

        [BindProperty]
        public NoCustomerAccountDTO Customer { get; set; }

        public CustomerManager cm = new CustomerManager(new CustomerDB());
        public TicketManager tm = new TicketManager(new TicketsDB(), new TicketsDB());
        private readonly IConfiguration _configuration;
        public void OnGet()
        {
            
        }

        public BuyTicketModel(IConfiguration configuration)
        {
            _configuration = configuration;
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

        public async Task<IActionResult> OnPostNoAccount()
        {
            if (ModelState.IsValid)
            {
                decimal price = 0;
                if (Ticket.Type == TypeOfTicket.adult)
                {
                    price = 8;
                }
                else if (Ticket.Type == TypeOfTicket.child)
                {
                    price = 6;
                }
                Ticket ticket = new Ticket(null, Ticket.Type, Ticket.Date, PlaceOfPerchase.online, price);
                tm.AddTicket(ticket);
                // Mail.SendAsync(Customer.Name,Customer.Email, ticket);
                await SendAsync(Customer.Name, Customer.Email, ticket);
                return RedirectToPage("Index");

            }
            return Page();
        }
        public  async Task SendAsync(string name, string clientEmail, Ticket product)
        {
            string senderName = _configuration.GetSection("MailboxAddress").GetSection("Name").Value;
            string sender = _configuration.GetSection("MailboxAddress").GetSection("Address").Value;

            var messageToSend = new MimeMessage
            {
                Sender = new MailboxAddress(senderName, sender),
                Subject = "Your Subject",
            };
            if (messageToSend == null) throw new ArgumentNullException(nameof(messageToSend));
            messageToSend.Body = new TextPart(TextFormat.Html) { Text = "test" };
            messageToSend.From.Add(new MailboxAddress(senderName, sender));
            messageToSend.To.Add(new MailboxAddress(name, clientEmail)); //important!!


            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.MessageSent += (sender, args) =>
                {
                    Console.WriteLine(args.Response);
                };
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await smtp.ConnectAsync("appssmtp.abv.bg", 465, SecureSocketOptions.None);
                //await smtp.AuthenticateAsync("Username", "Password");
                await smtp.SendAsync(messageToSend);
                await smtp.DisconnectAsync(true);
            };



        }
    }
}
