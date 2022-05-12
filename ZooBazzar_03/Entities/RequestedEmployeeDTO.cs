using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RequestedEmployeeDTO
    {
        public string Name {get;set;}
        public string Lastname { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string EmargencyContact { get; set; }
        public string Bsn { get; set; }
        public string Email { get; set; }
    }
}
