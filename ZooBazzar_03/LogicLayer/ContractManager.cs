using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace LogicLayer
{
    public class ContractManager
    {
        private List<EmployeeContract> contracts;
        private ContractDB cd ;

        IContractDataManagement<EmployeeContract> contractDataManagement;
        public ContractManager()
        {
            cd = new ContractDB();
            this.contractDataManagement = cd;
            contracts = contractDataManagement.GetContracts();
            //GetContracts();
        }


        public void AddContract(EmployeeContract ec, Employee employee)
        {
            cd.AddContract(ec, employee);
            employee.AssignContract(ec);
            contracts.Add(ec);
        }

        public void DisableContract(EmployeeContract ec)
        {
            cd.DisableContract(ec);
        }

        public List<EmployeeContract> GetContracts()
        {
            return contracts;
        }

        public List<EmployeeContract> GetContracts(Employee e)
        {
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            foreach (EmployeeContract ec in cd.GetContracts(e))
            {
                e.AssignContract(ec);
                contracts.Add(ec);
            }
            return contracts;
        }

    }
}
