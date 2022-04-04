using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:ZooBazzar_03/Modules/Specialist.cs
namespace Modules
========
namespace Entities
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/Entities/Specialist.cs
{
    public class Specialist
    {
        private int employeeId;
        private string name;
       
        public int EmployeeId { get { return employeeId; }  }
        public string Name { get { return name; }  }

        public Specialist(int id, string name)
        {
            this.employeeId = id;
            this.name = name;
        }
    }
}
