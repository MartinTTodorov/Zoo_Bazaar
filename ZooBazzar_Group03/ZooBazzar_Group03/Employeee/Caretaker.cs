using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class Caretaker : Employee
    {
        private Specialization specialization;
        public Caretaker(Account account,string name,string lastname,string phone,string email, string bsn,int age,Specialization specialization) : base(account,name,lastname,email,phone,bsn,age)
        {
            this.specialization = specialization;
        }

        public Specialization GetSpecialization()
        {
            return specialization;
        }
    }
}
