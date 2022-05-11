using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ZooBazzarWebApp.Pages
{
    public class SettingsModel : PageModel
    {
        private AccountManager accounManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());

        [Required]
        public string NewPassword { get; set; }

        public void OnPost()
        {
            Account account =accounManager.GetAccountByUsername(User.Identity.Name);
            Account newAccount = new Account(account.Username, NewPassword,account.Salt,account.Id);
            accounManager.UpdatePassword(newAccount);
        }
    }
}
