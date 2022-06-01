using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SalesMan: Employee
    {

        public SalesMan(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn) : base(account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn)
        {

        }
        public override string ToString()
        {
            return $"Salesman: {base.ToString()}";
        }
        public override string GetWorkingPosition()
        {
            return "Salesman";
        }
    }
}
