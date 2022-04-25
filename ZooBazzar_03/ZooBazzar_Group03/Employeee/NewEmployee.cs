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
using ZooBazzar_Group03.Employeee;

namespace ZooBazzar_Group03
{
    public partial class NewEmployee : Form
    {
        private EmployeeManagment managment = new EmployeeManagment();
        private AccountManager am = new AccountManager();
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
                    Employee caretaker = new Caretaker(account.Id, account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, specialization);
                    managment.AddEmployee(account.Id, caretaker);
                    ContractForm contractForm = new ContractForm((Employee)caretaker);
                    contractForm.Show();
                    this.Hide();

                }
                else if (cbPosition.SelectedItem.ToString() == "Manager")
                {
                    Employee manager = new Manager(account.Id, account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                    managment.AddEmployee(account.Id, manager);
                    ContractForm contractForm = new ContractForm((Employee)manager);
                    contractForm.Show();
                    this.Hide();
                }
                else
                {
                    Employee resourcePlanner = new ResourcePlanner(account.Id, account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                    managment.AddEmployee(account.Id, resourcePlanner);
                    ContractForm contractForm = new ContractForm((Employee)resourcePlanner);
                    contractForm.Show();
                    this.Hide();
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
