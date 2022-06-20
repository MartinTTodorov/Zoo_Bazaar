using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vacation
    {

        //Fields
        private int id;
        private int employeeID;
        private DateTime startDate;
        private DateTime endDate;

        //Properties
        public int ID { get { return id; } }
        public int EmployeeID { get { return employeeID; } }
        public DateTime StartDate { get { return startDate; } }
        public DateTime EndDate { get { return endDate; } }

        //Constructor
        public Vacation(int id, int employeeID, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.employeeID = employeeID;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        //Methods
        public void ValidateDates(DateTime startDate, DateTime endDate)
        {
            if (startDate.CompareTo(endDate) > 0)
            {
                throw new Exception("End date can't be before the start date");
            }
        }

    }
}
