using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class ChangeCredentialsModel : PageModel
    {
        [BindProperty]
        public RequestedEmployeeDTO Employee { get; set; }

        public RequestManager rm = new RequestManager(new RequestedEmployeeDB());
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                //RequestedEmployee re = new RequestedEmployee(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.).Value, Employee.Name, Employee.Lastname, Employee.Address, Employee.Birthdate, Employee.Email, Employee.Phone, Employee.EmargencyContact, Employee.Bsn);
                //rm.Add(re);
            }
            return Page();
        }
    }
}
