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
            contracts = cd.GetContracts();
            this.contractDataManagement = cd;
        }


        public void AddContract(EmployeeContract ec)
        {
            cd.AddContract(ec);
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

    }
}
