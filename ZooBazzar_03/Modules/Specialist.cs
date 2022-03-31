using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
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
