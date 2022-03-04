using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03.Employeee
{
    public class ResourcePlanner : Employee
    {
        public ResourcePlanner(Account account, string name, string lastname, string phone, string email, string bsn, int age) : base(account, name, lastname, email, phone, bsn, age)
        {

        }
    }
}
