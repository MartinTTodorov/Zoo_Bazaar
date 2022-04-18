using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DailySchedule
    {
        private int cageNumber;
        private string date;
        private int employeeId;

        public int CageNumber { get { return cageNumber; } }
        public string Date { get { return date; } }
        public int EmployeeId { get { return employeeId; } }


        public DailySchedule(int cageNr, string date, int id)
        {
            this.cageNumber = cageNr;
            this.date = date;
            this.employeeId = id;
        }

    }
}
