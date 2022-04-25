using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Manager : Employee
    {
        public Manager(Account account, string name, string lastname, string address,DateTime birthdate,string email, string phone,string emergencyContact, string bsn) : base(account, name, lastname,address,birthdate,email, phone,emergencyContact, bsn)
        {

        }

        public Manager(int id, Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn) : base( id, account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn)
        {

        }
        public override string ToString()
        {
            return $"Manager: {base.ToString()}";
        }
        public override string GetWorkingPosition()
        {
            return "Manager";
        }
    }
}
