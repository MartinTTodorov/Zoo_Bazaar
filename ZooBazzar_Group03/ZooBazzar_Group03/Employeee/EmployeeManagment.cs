using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class EmployeeManagment
    {
        public delegate void NewEmployeeEventHandler();
        public event NewEmployeeEventHandler NewEmployee;


        private List<Employee> employees = new List<Employee>();
        private EmployeeDB db = new EmployeeDB();
        public EmployeeManagment()
        {
            employees = db.Read();
        }

        
        public bool AddEmployee(Employee employee)
        {
            if (!employees.Contains(employee))
            {
                employees.Add(employee);
                OnNewEmployee();
                return true;
            }
            return false;
        }

        public bool RemoveEmployee(string name,string lastname)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Name == name & employees[i].Lastname == lastname)
                {
                    employees.Remove(employees[i]);
                    return true ;
                }
            }
            return false ;          
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public List<Caretaker> AllCaretakers()
        {
            List<Caretaker> result = new List<Caretaker>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Caretaker)
                {
                    result.Add((Caretaker)employees[i]);
                }
            }
            return result;
        }
        public List<Caretaker> CaretakersBySpecialization(Specialization specialization)
        {
            List<Caretaker> result = new List<Caretaker>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Caretaker)
                {
                    Caretaker caretaker = (Caretaker)employees[i];
                    if(caretaker.GetSpecialization() == specialization)
                    {
                       result.Add(caretaker);
                    }
                }
            }
            return result;
        }

        protected virtual void OnNewEmployee()
        {
            if (NewEmployee != null)
                NewEmployee();
        }

        private string positionCheck(Employee employee)
        {
            if (employee is Caretaker caretaker)
            {

                return caretaker.GetSpecialization().ToString();
            }
            else if (employee is ResourcePlanner)
            {
                return "Resource planner";
            }
            else
            {
                return "Manager";
            }
        }
    }
}
