using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Caretaker : Employee
    {
        private Specialization specialization;
        public Caretaker(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn,Specialization specialization) : base(account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn)
        {
            this.specialization = specialization;
        }

        public Specialization GetSpecialization()
        {
            return specialization;
        }

        public override string ToString()
        {
            return $"{this.specialization}: {base.ToString()}";
        }
        public override string GetWorkingPosition()
        {
            return $"{this.specialization}";
        }
    }
}
