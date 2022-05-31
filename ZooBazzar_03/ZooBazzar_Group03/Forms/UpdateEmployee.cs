using DataAccessLayer;
using Entities;
using LogicLayer;

namespace ZooBazzar_Group03.Forms
{
    public partial class UpdateEmployee : Form
    {
        //Fields
        private Employee employee;
        private EmployeeManagment managment = new EmployeeManagment(new EmployeeDB());
        private int index;

        //Constructor
        public UpdateEmployee(int index)
        {
            InitializeComponent();

            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            cbPosition.DataSource = new[] { "Caretaker", "Manager", "Resourceplanner" };

            employee = managment.GetEmployees()[index];
            tbName.Text = employee.Name;
            tbLastname.Text = employee.Lastname;
            tbAddress.Text = employee.Address;
            tbEmail.Text = employee.Email;
            tbPhone.Text = employee.Phone;
            tbEmergencyCon.Text = employee.EmargencyContact;
            dtpDateOfBirth.Value = employee.Birthdate;
            tbBSN.Text = employee.Bsn;
            cbPosition.SelectedText = employee.GetWorkingPosition();
            this.index = index;

            if (employee is Caretaker)
            {
                Caretaker caretaker = (Caretaker)employee;
                cbSpecialization.Text = caretaker.GetSpecialization().ToString();
                cbPosition.SelectedText = "Caretaker";
            }
        }

        //Events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if (cbPosition.SelectedItem.ToString() == "Caretaker")
                {
                    Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), cbSpecialization.SelectedItem.ToString());
                    Caretaker caretaker = new Caretaker(employee.Account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, specialization);
                    managment.UpdateEmployee(index, caretaker);
                }
                else if (cbPosition.SelectedItem.ToString() == "Manager")
                {
                    Manager manager = new Manager(employee.Account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                    managment.UpdateEmployee(index, manager);
                }
                else
                {
                    ResourcePlanner resourcePlanner = new ResourcePlanner(employee.Account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                    managment.AddEmployee(resourcePlanner);
                }

            }
            else
            {
                MessageBox.Show("You naughty nauhty you teasing meee, you naughty naughty!!!Enter all fields ;)");
            }
        }

        //Methods
        private bool checkInput()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {

                if (this.Controls[i] is TextBox)
                {
                    if (!DataValidation.CheckTextBox((TextBox)this.Controls[i]))
                    {
                        return false;
                    }

                }
                else if (this.Controls[i] is DateTimePicker)
                {
                    if (DataValidation.CheckFutureDate((DateTimePicker)this.Controls[i]))
                    {
                        return false;
                    }

                }


            }
            return true;
        }
    }
}
