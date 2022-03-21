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
        private static EmployeeManagment employeeManagment = new EmployeeManagment();
        AnimalDB animalDB = new AnimalDB();
        
        public static EmployeeManagment EmployeeManagment { get { return employeeManagment; } }
        public MainManu(Account account)
        {
            InitializeComponent();
            updateEmployeeUI();
            DummyData();
            lblHello.Text = $"Hello, {account.Username}!";
            employeeManagment.NewEmployee += this.OnNewEmployee;

            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));

            GetDate(0);
        }

        int index = 0;
        public void GetDate(int index)
        {
            calendar.Controls.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime day = DateTime.Now;

                Date uc = new Date();

                day = day.AddDays(i + index);
                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";
                string weekday = DateTime.Now.DayOfWeek.ToString();
                uc.GetDate(weekday, date);

                calendar.Controls.Add(uc);

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index -= 7;
            GetDate(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index += 7;
            GetDate(index);
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
        private void DummyData()
        {
            employeeManagment.AddEmployee(new Caretaker(new Account("Stoil", "1234"), "Stoil", "Yonchev", "+359888709760", "yonchev.stoil@gmail.com", "1029655555", 19, Specialization.Ornithologist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Radi", "4321"), "Radolina", "Petrova","+35965354780", "petrova.radolina@gmail.com", "1029655556", 19, Specialization.Entomologist));
            employeeManagment.AddEmployee(new Manager(new Account("Martin", "7894"), "Martin", "Todorov", "+35965354780", "todorov.martin@gmail.com", "1029655556", 19));
            employeeManagment.AddEmployee(new ResourcePlanner(new Account("Danilo", "1234"), "Danilo", "Gutesa", "+35965354780", "gutesa.danilo@gmail.com", "1029655556", 19));
            employeeManagment.AddEmployee(new Caretaker(new Account("Kalina", "1234"), "Kalina", "Grigorova", "+359888709760", "grigorova.kalina@gmail.com", "1029655555", 19, Specialization.Mammalogist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Ivan", "1234"), "Ivan", "Bekriev", "+359888709760", "bekriev.ivan@gmail.com", "1029655555", 19, Specialization.Herprtologist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Tsveta", "1234"), "Tsveta", "Pandurska", "+359888709760", "pandurska.tsveta@gmail.com", "1029655555", 19, Specialization.Ichthyologist));


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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
