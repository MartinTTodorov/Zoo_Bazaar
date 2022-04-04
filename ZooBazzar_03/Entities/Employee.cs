using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:ZooBazzar_03/Modules/Employee.cs
namespace Modules
========
namespace Entities
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/Entities/Employee.cs
{
    public abstract class Employee
    {

        private Account account;
        private string firstname;
        private string lastname;
        private string address;
        private DateTime birthdate;
        private string phone;
        private string email;
        private string emergencyContact;
        private string bsn;
        private int id;

        public Account Account { get { return account; } }
        public string Name { get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public string Address { get { return address; } }
        public DateTime Birthdate { get { return birthdate; } }
        public string Phone { get { return phone; } }
        public string EmargencyContact { get { return emergencyContact; } }
        public string Bsn { get { return bsn; } }
        public string Email { get { return email; } }
        public int Id { get { return id; } set { id = value; } }
        protected Employee(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn)
        {
            this.account = account;
            firstname = name;
            this.lastname = lastname;
            this.address = address;
            this.birthdate = birthdate;
            this.email = email;
            this.phone = phone;
            this.emergencyContact = emergencyContact;
            this.bsn = bsn;
        }

        protected Employee()
        {

        }

        public override string ToString()
        {
            return $"{Name} {Lastname} Id:{Id}";
        }

        public virtual string GetWorkingPosition()
        {
            return " ";
        }
    }
}
