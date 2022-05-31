using DataAccessLayer;
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

namespace ZooBazzar_Group03.Forms
{
    public partial class AddAccount : Form
    {
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbUsername.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                Account temp = new Account(tbUsername.Text, tbPassword.Text);

                if (!accountManager.isExisting(temp))
                {
                    AddEmployee addEmployee = new AddEmployee(temp);
                    //displa it here
                };

            }
        }
    }
}
