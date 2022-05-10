using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class DataManager
    {
        private static AccountManager accountManager = new AccountManager();
        private static AnimalManager animalManager = new AnimalManager();
        private static CageManager cageManager = new CageManager();
        private static ContractManager contractManager = new ContractManager();
        private static EmployeeManagment employeeManagment = new EmployeeManagment();

        public static AccountManager AccountManager { get { return accountManager; } }
        public static AnimalManager AnimalManager { get { return animalManager; } }
        public static CageManager CageManager { get { return cageManager; } }
        public static ContractManager ContractManager { get { return contractManager; } }
        public static EmployeeManagment EmployeeManagment { get { return employeeManagment; } }
    }
}
