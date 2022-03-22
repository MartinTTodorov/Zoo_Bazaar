

namespace ZooBazzar_Group03
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
    }
}
