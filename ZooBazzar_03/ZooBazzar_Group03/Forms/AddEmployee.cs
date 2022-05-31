using Entities;
using LogicLayer;
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

namespace ZooBazzar_Group03.Forms
{
    public partial class AddEmployee : Form
    {
        private Account account;
        private EmployeeManagment managment;
        public AddEmployee(Account account)
        {
            InitializeComponent();

            this.account = account;
        }
        
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                Employee tempEmployee = null;
                if (cbPosition.SelectedItem.ToString() == "Caretaker")
                {
                    Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), cbSpecialization.SelectedText);
                    tempEmployee = new Caretaker(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, specialization);
                    
                   
                }
                else if (cbPosition.SelectedItem.ToString() == "Manager")
                {
                    tempEmployee = new Manager(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                  
                }
                else
                {
                    tempEmployee = new ResourcePlanner(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text);
                   
                }

                managment.AddEmployee(tempEmployee);
                ContractForm newContract = new ContractForm(tempEmployee);

                // display it
                newContract.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
