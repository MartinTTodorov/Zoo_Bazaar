using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using DataAccessLayer;
using Entities;


namespace LogicLayer
{
    public class AccountManager
    {
        AccountManagerDB db = new AccountManagerDB();
        List<Account> accounts = new List<Account>();
        public List<Account> Accounts { get { return accounts; } }
        public AccountManager()
        {
            accounts = db.Read();
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
            db.Add(newAccount);
            accounts.Add(newAccount);
            return true;
        }

        public int GetAccountId()
        {
            return db.GetAccountId();
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

        public void UpdatePassword(string username,string password)
        {
            db.ChangePassword(username,password);
            RefreshData();
        }
        public string GetWorkPositionByAccount(string username)
        {
            return db.GetEmployeeWorkPositionByAccount(username);
        }
    }
}
