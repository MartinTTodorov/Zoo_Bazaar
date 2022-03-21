using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public abstract class Employee
    {
        
        private Account account;
        private string name;
        private string lastname;
        private int age;
        private string email;
        private string phone;
        private string bsn;
        private static int id ; //question
        
        
        public string Name { get { return name; }}
        public string Lastname { get { return lastname; } }
        public string Bsn { get { return bsn; }}
        public string Email { get { return email; } }

        protected Employee(Account account, string name, string lastname,string email,string phone,string bsn,int age)
        {
            this.account = account;
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.email = email;
            this.phone = phone;
            this.bsn = bsn;
        }

        protected Employee()
        {
        }
    }
}
