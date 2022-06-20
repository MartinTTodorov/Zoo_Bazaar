using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IVacations

    {
        
        public void RequestVacation(Vacation vacation);
        public void AcceptVacation(Vacation vacation);
        public void DenyVacation(Vacation vacation);
    }
}
