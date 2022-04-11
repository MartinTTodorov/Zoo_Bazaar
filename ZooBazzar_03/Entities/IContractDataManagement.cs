using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IContractDataManagement<EmployeeContract>
    {
        void AddContract(EmployeeContract ec);

        void DisableContract(EmployeeContract ec);

        List<EmployeeContract> GetContracts();
    }
}
