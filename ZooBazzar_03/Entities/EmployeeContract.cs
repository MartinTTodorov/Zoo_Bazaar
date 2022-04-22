using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmployeeContract
    {
        private int id;
        private int employeeId;
        private DateTime startDate;
        private DateTime endDate;
        private double fte;
        private string reason;
        private bool isValid;





        public int Id { get { return this.id; } }
        public int EmployeeId { get { return this.employeeId; } }
        public DateTime StartDate { get { return this.startDate; } }

        public DateTime EndDate { get { return this.endDate; } }

        public double Fte { get { return this.fte; } }
        public string Reason { get { return this.reason; } }
        public bool IsValid { get { return this.isValid; } }

        public EmployeeContract(int id,int employeeId, DateTime startDate, DateTime endDate, double fte, string reason, bool isValid)
        {
            this.id = id;
            this.employeeId = employeeId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.fte = fte;
            this.reason = reason;
            this.isValid = isValid;
        }


        public EmployeeContract()
        {

        }

        public override string ToString()
        {
            return $"Start Date: {StartDate} End Date: {EndDate} FTE: {fte}  Reason: {Reason}";
        }
    }
}

