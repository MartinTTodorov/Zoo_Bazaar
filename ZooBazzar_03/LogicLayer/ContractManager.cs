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

        IContractDataManagement<EmployeeContract> contractDataManagement;
        public ContractManager(IContractDataManagement<EmployeeContract> contractDataManagement)
        {
            this.contractDataManagement = contractDataManagement;
            contracts = contractDataManagement.GetContracts();
            //GetContracts();
        }


        public void AddContract(EmployeeContract ec, Employee employee)
        {
            contractDataManagement.AddContract(ec, employee);
            employee.AssignContract(ec);
            contracts.Add(ec);
        }

        public void DisableContract(EmployeeContract ec)
        {
            contractDataManagement.DisableContract(ec);
        }

        public List<EmployeeContract> GetContracts()
        {
            return contracts;
        }

        public List<EmployeeContract> GetContracts(Employee e)
        {
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            foreach (EmployeeContract ec in contractDataManagement.GetContracts(e))
            {
                e.AssignContract(ec);
                contracts.Add(ec);
            }
            return contracts;
        }

    }
}
