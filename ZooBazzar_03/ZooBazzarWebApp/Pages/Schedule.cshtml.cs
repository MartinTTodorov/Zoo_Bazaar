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
        private List<DailySchedule> schedules;

        private ScheduleManager scheduleManager;
        private EmployeeManagment employeeManagment;

        public ScheduleModel(ScheduleManager sm,EmployeeManagment em)
        {
            scheduleManager = sm;
            employeeManagment = em;
            
        }
        public void OnGet()
        {
            currentEmployee = employeeManagment.AllCaretakers().Find(e => e.Id == Convert.ToInt32(User.FindFirst("ID").Value));
            schedules = scheduleManager.GetCaretakerSchedule((Caretaker)currentEmployee, DateTime.Now, 0);
        }

        public List<string> GetWeek(int i)
        {
            return GUIHelper.GetWeek(DateTime.Today, i);
        }
        public List<Cage> getCages(DailySchedule ds)
        {
            return scheduleManager.GetCages(ds.TimeSlot, ds.Type, DateTime.ParseExact(ds.Date, "d MMM yyyy", null));
        }
        
        private List<DailySchedule> GetShifts(string time)
        {
            return schedules.FindAll(x => x.TimeSlot == time);
        }

        public DailySchedule GetShift(string time, int date)
        {
            return GetShifts(time).Find(x => (int)DateTime.ParseExact(x.Date, "dd MMM yyyy", null).DayOfWeek == date);
        }

    }
}
