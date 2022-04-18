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

        public int CageNumber { get; }
        public string Date { get; }
        public int EmployeeId { get; }


        public DailySchedule(int cageNr, string date, int id)
        {
            this.cageNumber = cageNr;
            this.date = date;
            this.employeeId = id;
        }

    }
}
