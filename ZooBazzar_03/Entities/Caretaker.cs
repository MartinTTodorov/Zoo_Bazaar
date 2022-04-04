using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:ZooBazzar_03/Modules/Caretaker.cs
namespace Modules
========
namespace Entities
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/Entities/Caretaker.cs
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
