using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazzarWebApp.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        public Employee currentEmployee;
        public List<DailySchedule> schedules;
        public ScheduleManager ScheduleManager = new ScheduleManager(new ScheduleDB(), new EmployeeDB(), new CageDB(), new ContractDB());
        public void OnGet()
        {            
            currentEmployee = (new EmployeeManagment(new EmployeeDB())).GetEmployees().Find(e => e.Id == Convert.ToInt32(User.FindFirst("ID").Value));
            schedules = ScheduleManager.GetCaretakerSchedule((Caretaker)currentEmployee, DateTime.Now, 0);
        }

        public List<Cage> getCages(DailySchedule ds)
        {
            return ScheduleManager.GetCages(ds.TimeSlot, ds.Type, DateTime.ParseExact(ds.Date, "d MMM yyyy", null));
        }
        
    }
}
