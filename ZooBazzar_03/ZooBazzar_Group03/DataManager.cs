using DataAccessLayer;
using LogicLayer;


namespace ZooBazzar_Group03
{
    public static class DataManager
    {
        private static AccountManager accountManager = new AccountManager(new AccountManagerDB());
        private static EmployeeManagment employeeManagment = new EmployeeManagment(new EmployeeDB());
        private static ContractManager contractManager = new ContractManager(new ContractDB());
        private static AnimalManager animalManager = new AnimalManager(new AnimalDB());
        private static CageManager cageManager = new CageManager(new CageDB());
    }
}
