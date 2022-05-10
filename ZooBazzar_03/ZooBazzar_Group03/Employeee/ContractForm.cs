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
    public partial class ContractForm : Form
    {
        private ContractManager cm;
        private Employee employee;
        public ContractForm(Employee employeee)
        {
            InitializeComponent();
            cm = new ContractManager(new ContractDB());
            this.employee = employeee;

        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                EmployeeContract employeeContract = new EmployeeContract(employee.Id, dtpStartDate.Value, dtpEndDate.Value, Convert.ToDouble(tbFte.Text), tbReason.Text, true);
                cm.AddContract(employeeContract, employee);
                MessageBox.Show("Successful creation of Contract!");
                this.Close();
            }

            else
            {
                MessageBox.Show("Please enter all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
