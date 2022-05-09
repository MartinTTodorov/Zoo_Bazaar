using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03.Employeee
{
    public partial class EditEmployee : Form
    {
        Employee employee;
        EmployeeManagment managment = new EmployeeManagment(new EmployeeDB());
        int index;
        public EditEmployee(int index)
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

        private void btnEditEmployee_Click(object sender, EventArgs e)
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
                managment.AddEmployee( resourcePlanner);
            }

            }
            else
            {
                MessageBox.Show("You naughty nauhty you teasing meee, you naughty naughty!!!Enter all fields ;)");
            }
        }

        private bool checkInput()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)this.Controls[i];
                    for (int j = 0; j < groupBox.Controls.Count; j++)
                    {
                        if (groupBox.Controls[j] is TextBox)
                        {
                            if (!DataValidation.CheckTextBox((TextBox)groupBox.Controls[j]))
                            {
                                return false;
                            }

                        }
                        else if (groupBox.Controls[j] is DateTimePicker)
                        {
                            if (DataValidation.CheckFutureDate((DateTimePicker)groupBox.Controls[j]))
                            {
                                return false;
                            }

                        }
                    }
                }
            }
            return true;
        }

    }
}
