using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:ZooBazzar_03/Modules/Account.cs
namespace Modules
========
namespace Entities
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/Entities/Account.cs
{
    public class Account
    {
        private int id;
        private string username;
        private string password;
        public string Username { get { return username; } private set { username = value; } }
        public string Password { get { return password; }  set { password = value; } }
        public int Id { get { return id; } set { id = value; } }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
       
    }
}
