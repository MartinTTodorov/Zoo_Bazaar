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

namespace ZooBazzar_Group03
{
    public partial class NewEmployee : Form
    {
        private EmployeeManagment managment = new EmployeeManagment(new EmployeeDB());
        private Account account;

        public NewEmployee(Account newAccount)
        {
            InitializeComponent();
            cbSpecialization.Visible = false;
            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            cbPosition.DataSource = new[] { "Caretaker", "Manager", "Resourceplanner" };
            account = newAccount;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if (cbPosition.SelectedItem.ToString() == "Caretaker")
                {
                    Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), cbSpecialization.SelectedItem.ToString());
                    Caretaker caretaker = new Caretaker(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, specialization);
                    managment.AddEmployee( caretaker);
                }
                else if (cbPosition.SelectedItem.ToString() == "Manager")
                {
                    Manager manager = new Manager(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                    managment.AddEmployee( manager);
                }
                else
                {
                    ResourcePlanner resourcePlanner = new ResourcePlanner(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                    managment.AddEmployee( resourcePlanner);
                }

            }
            else
            {
                MessageBox.Show("Please enter all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.SelectedItem.ToString() == "Caretaker")
            {
                cbSpecialization.Visible = true;

            }
            else
            {
                cbSpecialization.Visible = false;
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
                        else if(groupBox.Controls[j] is DateTimePicker)
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
