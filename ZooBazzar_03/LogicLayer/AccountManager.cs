using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace LogicLayer
{
    public class AccountManager
    {
        private ICRUD<Account> db;
        private IAutoIncrementable auto;
        private List<Account> accounts = new List<Account>();
        public List<Account> Accounts { get { return accounts; } }
        public AccountManager(ICRUD<Account> db,IAutoIncrementable a)
        {
            this.db = db;
            auto = a;
            accounts = this.db.Read();
        }

        public bool AddAccount(Account newAccount)
        {
            string[] hashedPassword = HashedPassword(newAccount.Password);
            Account temp = new Account(newAccount.Username, hashedPassword[0],hashedPassword[1],auto.GetNextID());

            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].Username == temp.Username)
                {
                    return false;
                }
            }
            db.Add(temp);
            accounts.Add(temp);
            return true;
        }

        public bool RemoveAccount(int index)
        {
            if(accounts[index] != null)
            {
                db.Delete(accounts[index].Id);
                accounts.RemoveAt(index);
                return true;
            }
            return false;
        }
        public bool Login(string username, string password)
        {
            foreach (Account a in accounts)
            {
                if (a.Username == username && a.Password == password)
                {
                    return true;
                }
            }

            return false;
        }      
        
        public Account GetAccountByCredentials(string username, string password)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].Username == username && accounts[i].Password == password)
                {
                    return accounts[i];
                }
            }
            return null;
        }
        public void RefreshData()
        {
            accounts = db.Read();
        }

        public void UpdatePassword(Account account)
        {
            string[] hashedPassword = HashedPassword(account.Password);
            Account temp = new Account(account.Username, hashedPassword[0], hashedPassword[1],account.Id);
            db.Update(temp.Id, temp);
            RefreshData();
        }
        public string GetWorkPositionByAccount(string username)
        {
            return db.GetEmployeeWorkPositionByAccount(username);
        }
        public string[] HashedPassword(string password)
        {
            string salt = Guid.NewGuid().ToString();

            return new string[] { PasswordHasher.HashPassword(password + salt), salt };
        }
    }
}
