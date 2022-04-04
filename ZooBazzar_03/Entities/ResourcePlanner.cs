using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:ZooBazzar_03/Modules/ResourcePlanner.cs
namespace Modules
========
namespace Entities
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/Entities/ResourcePlanner.cs
{
    public class ResourcePlanner : Employee
    {
        public ResourcePlanner(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn) : base(account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn)
        {

        }
        public override string ToString()
        {
            return $"Resource planner: {base.ToString()}";
        }
        public override string GetWorkingPosition()
        {
            return "Resourceplanner";
        }
    }
}
