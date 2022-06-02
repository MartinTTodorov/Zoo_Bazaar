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

        public EmployeeManagment em = new EmployeeManagment(new EmployeeDB());

        public RequestManager rm = new RequestManager(new RequestedEmployeeDB());

        public Employee employee;


        public void OnGet()
        {
            employee = em.GetEmployeeByUsername(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Employee currentEmployee = em.GetEmployeeByUsername(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value);
                RequestedEmployee re = new RequestedEmployee(currentEmployee.Id, Employee.Name, Employee.Lastname, Employee.Address, Employee.Birthdate, Employee.Email, Employee.Phone, Employee.EmargencyContact, Employee.Bsn);
                rm.Add(re);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
