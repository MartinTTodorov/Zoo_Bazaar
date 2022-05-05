using DataAccessLayer;
using LogicLayer;


namespace ZooBazzar_Group03
{
    public static class DataManager
    {
        private static AccountManager accountManager = new AccountManager();
        private static EmployeeManagment employeeManagment = new EmployeeManagment();
        private static ContractManager contractManager = new ContractManager();
        private static AnimalManager animalManager = new AnimalManager();
        private static CageManager cageManager = new CageManager();
    }
}
