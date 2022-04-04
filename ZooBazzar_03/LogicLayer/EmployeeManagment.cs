using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<<< HEAD:ZooBazzar_03/LL/EmployeeManagment.cs
using Modules;
using DAL;

namespace LL
========
using DataAccessLayer;
using Entities;


namespace LogicLayer
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/LogicLayer/EmployeeManagment.cs
{
    public class EmployeeManagment
    {
        public delegate void ChangedEmployeeEventHandler();
        public event ChangedEmployeeEventHandler ChangedEmployee;


        private List<Employee> employees = new List<Employee>();
        private EmployeeDB db = new EmployeeDB();
        public EmployeeManagment()
        {
            employees = db.Read();
        }

        
        public bool AddEmployee(int accountid,Employee employee)
        {
            if (!employees.Contains(employee))
            {
                db.Add(accountid,employee);
                employees.Add(employee);
                OnChangedEmployee();
                return true;
            }
            return false;
        }

        public bool RemoveEmployee(int index)
        {                        
                if (index >=0)
                {
                    DataRefresh();
                    db.Delete(employees[index].Id);
                    employees.RemoveAt(index);
                    OnChangedEmployee();
                    return true ;
               }
               return false;                   
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

        protected virtual void OnChangedEmployee()
        {
            if (ChangedEmployee != null)
                ChangedEmployee();
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
        public void DataRefresh()
        {
            employees = db.Read();
        }

        public void UpdateEmployee(int index,Employee employee)
        {
            if(index >= 0)
            {
                db.Update(employees[index].Id, employee);
                employees[index] = employee;
                OnChangedEmployee();
            }
        }
    }
}
