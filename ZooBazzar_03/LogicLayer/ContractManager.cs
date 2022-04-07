using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class ContractManager
    {
        private List<EmployeeContract> contracts;
        public ContractManager()
        {
            contracts = new List<EmployeeContract>();
        }


    }
}
