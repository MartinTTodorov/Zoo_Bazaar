using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazzar_Group03.Employeee;

namespace ZooBazzar_Group03
{
    public partial class MainManu : Form
    {
        private EmployeeManagment employeeManagment = new EmployeeManagment();
        public MainManu(Account account)
        {
            InitializeComponent();
            updateEmployeeUI();
            DummyData();
            lblHello.Text = $"Hello, {account.Username}!";
        }

        private void MainManu_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateEmployeeUI();
        }

        private void updateEmployeeUI()
        {
           List<Employee> employees = employeeManagment.GetEmployees();

           flpEmployees.Controls.Clear();
           foreach(Employee e in employees)
            {
                flpEmployees.Controls.Add(new ucEmployee(e));

            }           
        }

        private void DummyData()
        {
            employeeManagment.AddEmployee(new Caretaker(new Account("Stoil", "1234"), "Stoil", "Yonchev", "+359888709760", "yonchev.stoil@gmail.com", "1029655555", 19, Specialization.Ornithologist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Radi", "4321"), "Radolina", "Petrova","+35965354780", "petrova.radolina@gmail.com", "1029655556", 19, Specialization.Entomologist));
            employeeManagment.AddEmployee(new Manager(new Account("Martin", "7894"), "Martin", "Todorov", "+35965354780", "todorov.martin@gmail.com", "1029655556", 19));
        }
    }
}
