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
        private Employee employee;
        private DateTime startDate;
        private DateTime endDate;
        private double fte;
        private string reason;
        private bool isValid;

        public EmployeeContract(int id, Employee employee, DateTime startDate, DateTime endDate, double fte, string reason, bool isValid)
        {
            this.id = id;
            this.employee = employee;
            this.startDate = startDate;
            this.endDate = endDate;
            this.fte = fte;
            this.reason = reason;
            this.isValid = isValid;
        }


        public EmployeeContract()
        {

        }

        public int Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Fte { get; set; }
        public string Reason { get; set; }
        public bool IsValid { get; set; } }
    }

