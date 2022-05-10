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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if (accountManager.AddAccount(new Account(tbUsername.Text, tbPassword.Text)))
                {
                    accountManager.RefreshData();
                    NewEmployee newEmployee = new NewEmployee(accountManager.GetAccountByCredentials(tbUsername.Text, tbPassword.Text));
                    newEmployee.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Account with the same username exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


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
                    }
                }
            }
            return true;
        }
    }
}
