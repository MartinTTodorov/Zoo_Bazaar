using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace LogicLayer
{
    public class VacationManager
    {

        private EmployeeManagment employeeManager = new EmployeeManagment(new EmployeeDB());
        private ContractManager contractManager = new ContractManager(new ContractDB());
        private List<Vacation> vacations;
        private IVacations db;

        public List<Vacation> Vacations { get { return vacations; } }

        public VacationManager(IVacations db)
        {
            this.db = db;
            vacations = db.ReadVacations();
        }

        

        public void RequestVacation(Vacation vacation)
        {
            Employee employee = employeeManager.GetEmployeeById(vacation.EmployeeID);
            EmployeeContract contract = contractManager.GetActiveContract(employee);
            
            if (!(Convert.ToInt32((vacation.EndDate.Date-vacation.StartDate.Date).TotalDays) <= contract.VacationDaysLeft))
            {
                throw new Exception($"This vacation is longer than your vacation limit! Vacation days left: {contract.VacationDaysLeft}");
            }
            db.RequestVacation(vacation);
        }

        public void AcceptVacation(Vacation vacation)
        {
            Employee employee = employeeManager.GetEmployeeById(vacation.EmployeeID);
            EmployeeContract contract = contractManager.GetActiveContract(employee);
            int vacationLength = Convert.ToInt32((vacation.EndDate.Date - vacation.StartDate.Date).TotalDays);
            contractManager.ReduceVacationDays(contract, vacationLength);
            db.AcceptVacation(vacation);
        }

        public void DenyVacation(Vacation vacation)
        {
            db.DenyVacation(vacation);
        }

        
    }
}
