using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class EmployeeManagment
    {
        private List<Employee> employees = new List<Employee>();
        
        public bool AddEmployee(Employee employee)
        {
            if (!employees.Contains(employee))
            {
                employees.Add(employee);
                return true;
            }
            return false;
        }

        public bool RemoveEmployee(string bsn)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Bsn == bsn)
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
    }
}
