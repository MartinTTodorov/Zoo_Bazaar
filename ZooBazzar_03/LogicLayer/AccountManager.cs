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
        List<Account> accounts = new List<Account>();
        public List<Account> Accounts { get { return accounts; } }

        ICRUD<Account> crud;
        public AccountManager(ICRUD<Account> crud)
        {
            this.crud = crud;
            accounts = crud.Read();
        }

        public bool AddAccount(Account newAccount)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].Username == newAccount.Username)
                {
                    return false;
                }
            }
            crud.Add(newAccount);
            accounts.Add(newAccount);
            return true;
        }

        public bool RemoveAccount(int index)
        {
            if(accounts[index] != null)
            {
                crud.Delete(accounts[index].Id);
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
            accounts = crud.Read();
        }

        public void UpdatePassword(string username,string password)
        {
            crud.ChangePassword(username,password);
            RefreshData();
        }
        public string GetWorkPositionByAccount(string username)
        {
            return crud.GetEmployeeWorkPositionByAccount(username);
        }
    }
}
