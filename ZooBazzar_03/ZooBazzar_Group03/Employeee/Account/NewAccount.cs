using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03.Employeee
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }
        private AccountManager accountManager = new AccountManager();
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            accountManager.AddAccount(new Account(tbUsername.Text,tbPassword.Text));
            accountManager.RefreshData();
            NewEmployee newEmployee = new NewEmployee(accountManager.GetAccountByCredentials(tbUsername.Text, tbPassword.Text));
            newEmployee.Show();
            this.Hide();
        }
    }
}
