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
        public EmployeeManagment em;
        public Employee employee;

        public ProfileModel(EmployeeManagment em)
        {
            this.em = em;
        }

        public void OnGet()
        {
            employee = em.Employees.First(e => e.Id == Convert.ToInt32(User.FindFirst("ID").Value));

        }
    }
}
