using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
            cbSpecialization.Visible = false;
            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            cbPosition.DataSource = new[] { "Caretaker", "Manager", "Resourceplanner" };
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
           
            if(cbPosition.SelectedItem.ToString() == "Caretaker")
            {
                MainManu.EmployeeManagment.AddEmployee(new Caretaker(new Account(tbUsername.Text, tbPassword.Text), tbName.Text, tbLastname.Text, tbPhone.Text, tbEmail.Text, tbBSN.Text, (int)numAge.Value, (Specialization)cbSpecialization.SelectedItem));
            }
            else if(cbPosition.SelectedItem.ToString() == "Manager")
            {
                MainManu.EmployeeManagment.AddEmployee(new Manager(new Account(tbUsername.Text, tbPassword.Text), tbName.Text, tbLastname.Text, tbPhone.Text, tbEmail.Text, tbBSN.Text, (int)numAge.Value));
            }
            else
            {
                MainManu.EmployeeManagment.AddEmployee(new ResourcePlanner(new Account(tbUsername.Text, tbPassword.Text), tbName.Text, tbLastname.Text, tbPhone.Text, tbEmail.Text, tbBSN.Text, (int)numAge.Value));
            }
           
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPosition.SelectedItem.ToString() == "Caretaker")
            {
                cbSpecialization.Visible = true;

            }
            else
            {
                cbSpecialization.Visible = false;
            }
        }
    }
}
