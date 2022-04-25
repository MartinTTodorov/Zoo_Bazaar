using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
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

        public Account(int id, string username, string password)
        {
            this.id = id;   
            this.username = username;
            this.password = password;
        }

    }
}
