using ZooBazzar_Group03.Employeee;
using LogicLayer;
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class MainManu : Form
    {
        private Account currentAccount;
        private EmployeeManagment employeeManagment = new EmployeeManagment(new EmployeeDB());
        private ScheduleManager scheduleManager = new ScheduleManager(new ScheduleDB(), new EmployeeDB(), new CageDB(), new ContractDB());
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());
        private AnimalManager animalManager = new AnimalManager(new AnimalDB());
        private ContractManager cm = new ContractManager(new ContractDB());
        private RequestManager rm = new RequestManager(new RequestedEmployeeDB());

        public MainManu(Account account)
        {
            InitializeComponent();
            updateEmployeeUI();
            accessability(accountManager.GetWorkPositionByAccount(account.Username));
            lblHello.Text = $"Hello, {account.Username}!";
            employeeManagment.ChangedEmployee += OnChangedEmployee;
            tbUsernameSettings.Text = account.Username;
            tbPasswordSettings.Text = account.Password;
            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            updateEmployee();
            GetSchedule(0);
            currentAccount = account;
            LoadContracts();
            LoadRequests();
        }


        int index = 0;

        private void GetSchedule(int index)
        {
            calendar.Controls.Clear();

            List<string> days = scheduleManager.GetWeek(DateTime.Now, index);


            for (int i = 0; i < days.Count; i++)
            {
                ucDate uc = new ucDate();
                uc.GetDate(days[i]);
                calendar.Controls.Add(uc);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index -= 7;
            GetSchedule(index);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index += 7;
            GetSchedule(index);
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
            foreach (Employee e in employees)
            {
                flpEmployees.Controls.Add(new ucEmployee(e));

            }
        }
        private void updateEmployeeUIbySpecialization(Specialization specialization)
        {
            List<Caretaker> caretakers = employeeManagment.CaretakersBySpecialization(specialization);
            flpEmployees.Controls.Clear();
            foreach (Caretaker c in caretakers)
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
                if (string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase) || e.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
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

        }

        public void OnChangedEmployee()
        {
            employeeManagment.DataRefresh();
            updateEmployee();
            updateEmployeeUI();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnShowAllAnimals_Click(object sender, EventArgs e)
        {
            UpdateAnimals();
        }

        public void UpdateAnimals()
        {
            flpAnimals.Controls.Clear();
            animalManager.UpdateLocalList();
            //for (int i = 0; i < animalManager.animals.Count; i++)
            //{
            //    if (animalManager.animals[i].ReasonForDeparture == String.Empty)
            //    {
            //        AnimalPic animalPic = new AnimalPic(animalManager.animals[i], this,accountManager.GetWorkPositionByAccount(currentAccount.Username));
            //        flpAnimals.Controls.Add(animalPic);
            //    }
            //}

            foreach (Animal animal in animalManager.Animals)
            {
                if (animal.ReasonForDeparture == String.Empty)
                {
                    AnimalPic animalPic = new AnimalPic(animal, this, accountManager.GetWorkPositionByAccount(currentAccount.Username));
                    flpAnimals.Controls.Add(animalPic);
                }
            }
        }


        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            FormAddAnimal frmAddAnimal = new FormAddAnimal(this);
            frmAddAnimal.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }

        private void updateEmployee()
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in employeeManagment.GetEmployees())
            {
                lbEmployees.Items.Add(employee);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex >= 0 && lbEmployees.SelectedIndex < employeeManagment.GetEmployees().Count)
            {
                EditEmployee editEmployee = new EditEmployee(lbEmployees.SelectedIndex);
                editEmployee.Show();
            }
        }

        private void btnRemoveEmployee_Click_1(object sender, EventArgs e)
        {
            if (lbEmployees.SelectedIndex >= 0 && lbEmployees.SelectedIndex < employeeManagment.GetEmployees().Count)
            {
                employeeManagment.RemoveEmployee(lbEmployees.SelectedIndex);
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            accountManager.UpdatePassword(new Account(currentAccount.Username, tbPasswordSettings.Text,currentAccount.Id));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
        private void accessability(string workingPosition)
        {

            if (workingPosition == "Manager")
            {

            }
            else if (workingPosition == "Resourceplanner")
            {
                tabControl1.TabPages.Remove(tpEmployeeManagment);
                tabControl1.TabPages[tpAnimals.Name].Controls[btnAddAnimal.Name].Enabled = false;
            }
            else
            {
                tabControl1.TabPages.Remove(tpEmployeeManagment);
                tabControl1.TabPages.Remove(tpSchedule);
                tabControl1.TabPages[tpAnimals.Name].Controls[btnAddAnimal.Name].Enabled = false;
            }
        }

        private void lbEmployees_DoubleClick(object sender, EventArgs e)
        {
            //Employee employee = (Employee)lbEmployees.SelectedItem;
            //foreach (EmployeeContract ec in cm.GetContracts(employee) )
            //{
            //    MessageBox.Show(ec.ToString());
            //}

            Employee employee = (Employee)lbEmployees.SelectedItem;
            foreach (EmployeeContract ec in cm.GetContracts(employee))
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadContracts()
        {
            lbContracts.Items.Clear();
            foreach (EmployeeContract ec in cm.GetContracts())
            {
                lbContracts.Items.Add(ec);
            }
        }

        private void btnDisableContract_Click(object sender, EventArgs e)
        {
            if (lbContracts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a contract");
                return;
            }

            EmployeeContract ec = (EmployeeContract)lbContracts.SelectedItem;

            cm.DisableContract(ec);
            MessageBox.Show($"Successful disabling the conract with id : {ec.Id}");
        }

        private void LoadRequests()
        {
            lbEmployeesWithNewCredentials.Items.Clear();
            foreach (RequestedEmployee re in rm.Read())
            {
                lbEmployeesWithNewCredentials.Items.Add(re);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbEmployeesWithNewCredentials.SelectedIndex <= -1)
            {
                MessageBox.Show("Please, select the employee!");
                return;
            }
            else
            {
                RequestedEmployee re = (RequestedEmployee)lbEmployeesWithNewCredentials.SelectedItem;
                rm.ChangeCredentials(re);
                rm.Delete(re);
                MessageBox.Show("Employee's been changed!");
                lbEmployeesWithNewCredentials.Items.Remove(re);
                LoadRequests();
                return;
            }

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee's not been changed!");
            RequestedEmployee re = (RequestedEmployee)lbEmployeesWithNewCredentials.SelectedItem;
            rm.Delete(re);
        }
    }
}
