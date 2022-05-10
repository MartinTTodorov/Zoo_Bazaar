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
        private AccountManager accountManager = new AccountManager();

        [BindProperty]
        public AccountDTO Account { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Account temp = accountManager.Accounts.Find(a => a.Username == Account.Username);

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
                        new Claim(ClaimTypes.Role, accountManager.GetWorkPositionByAccount(Account.Username))

            }, CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return new RedirectToPageResult("Index");

        }

    }
}
