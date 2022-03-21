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
        public EmployeeManagment EmployeeManagment { get { return employeeManagment; } }
        public MainManu(Account account)
        {
            InitializeComponent();
            updateEmployeeUI();           
            lblHello.Text = $"Hello, {account.Username}!";
            //employeeManagment.NewEmployee += this.OnNewEmployee;

            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
        }

        private void MainManu_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateEmployeeUI();
        }
        private void btnFindBySpecialization_Click(object sender, EventArgs e)
        {
            updateEmployeeUIbySpecialization((Specialization)cbSpecialization.SelectedItem);
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
        private void updateEmployeeUIbySpecialization(Specialization specialization)
        {
            List<Caretaker> caretakers = employeeManagment.CaretakersBySpecialization(specialization);
            flpEmployees.Controls.Clear();
            foreach (Caretaker c in caretakers )
            {
                flpEmployees.Controls.Add(new ucEmployee(c));
            }
        }

        private void updateEmployeeUIbyFirstName(string name)
        {
            List<Employee> employees = employeeManagment.GetEmployees();

            flpEmployees.Controls.Clear();
            foreach (Employee e in employees)
            {
                if(string.Equals(e.Name,name,StringComparison.OrdinalIgnoreCase) || e.Name.Contains(name,StringComparison.OrdinalIgnoreCase))
                {                
                    flpEmployees.Controls.Add(new ucEmployee(e));
                }

            }
        }
        

        private void btnFindByFirstName_Click(object sender, EventArgs e)
        {
            updateEmployeeUIbyFirstName(tbFirstName.Text);
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.Show();
        }

        public void OnNewEmployee(object sender, EventArgs e)
        {
            updateEmployeeUI();
        }
    }
}
