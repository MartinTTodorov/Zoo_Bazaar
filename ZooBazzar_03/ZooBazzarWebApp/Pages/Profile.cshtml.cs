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
            employee = (new EmployeeManagment(new EmployeeDB())).GetEmployees().Find(e => e.Id == Convert.ToInt32(User.FindFirst("ID").Value));

        }
    }
}
