using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class ProfileModel : PageModel
    {
        public EmployeeManagment em = new EmployeeManagment(new EmployeeDB());
        public Employee employee;

        public void OnGet()
        {
            employee = em.GetEmployeeByUsername(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value);

        }
    }
}
