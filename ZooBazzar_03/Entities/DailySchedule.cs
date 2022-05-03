using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DailySchedule
    {
        private Cage cage;
        private string date;
        private Employee employee;
        private string timeSlot;

        public Cage Cage { get { return cage; } }
        public string Date { get { return date; } }
        public string TimeSlot { get { return timeSlot; } }
        public Employee Employee { get { return employee; } }


        public DailySchedule(Cage cage, string date, Employee employee, string timeSlot)
        {
            this.cage = cage;
            this.date = date;
            this.employee = employee;
            this.timeSlot = timeSlot;
        }


        //Not id save a cage
        //Not relly on the gui to check if the caretaker is specialized
        //List of animals in the cage class   --- methods - getCurrentSpecies or smth like that


    }
}
