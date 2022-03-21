

namespace ZooBazzar_Group03
{
    public class AccountManager
    {
        List<Account> accounts = new List<Account>();
        public List<Account> Accounts { get { return accounts; } }

        public bool AddAccount(Account newAccount)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].Username == newAccount.Username)
                {
                    return false;
                }
            }
            accounts.Add(newAccount);
            return true;
        }

        public bool RemoveAccount(Account account)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i] == account)
                {
                    accounts.Remove(account);
                    return true;
                }
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

        public bool ChangePassword(Account account, string newPassword)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i] == account)
                {
                    accounts[i].Password = newPassword;
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
    }
}
