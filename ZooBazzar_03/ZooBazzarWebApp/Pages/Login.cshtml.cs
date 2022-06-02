using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class LoginModel : PageModel
    {
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(),new AccountManagerDB());
        private TicketManager tm = new TicketManager(new TicketDB());
        private CustomerManager cm = new CustomerManager(new CustomerDB());

        [BindProperty]
        public AccountDTO Account { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Account temp = accountManager.GetAccountByUsername(Account.Username);
                if (temp != null && temp.Password == PasswordHasher.HashPassword(Account.Password + temp.Salt))
                {
                    return Login();
                }
            }
            return new PageResult();
        }
        public IActionResult Login()
        {

            ClaimsIdentity identity = new ClaimsIdentity(new Claim[]
            {
                        new Claim(ClaimTypes.Name, Account.Username),
                        new Claim(ClaimTypes.Email, cm.GetCustomer(accountManager.GetAccountByUsername(Account.Username).Id).Email),
                        new Claim(ClaimTypes.Role, accountManager.GetWorkPositionByAccount(Account.Username)),
                        new Claim("ID",accountManager.GetAccountByUsername(Account.Username).Id.ToString())

            }, CookieAuthenticationDefaults.AuthenticationScheme);;

            HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return new RedirectToPageResult("Index");

        }

    }
}
