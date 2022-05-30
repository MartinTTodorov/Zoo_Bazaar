using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Entities
{
    public class Customer
    {
        //Fields
        private int id;
        private string email;
        private string firstName;
        private string lastName;

        public int Id { get { return id; } }
        public string Email
        {
            get { return email; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Regex validateEmail = new Regex("?< user >[^@] +)@(?< host >.+)");
                    if (!validateEmail.IsMatch(email.ToLower().ToString()))
                    {
                        throw new Exception("Invalid email");
                    }

                }
            }
        }
        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (!double.TryParse(value, out double result))
                    {
                        firstName = value;
                    }
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (!double.TryParse(value, out double result))
                    {
                        lastName = value;
                    }
                }
            }
        }

        //Constructor
        public Customer(int id, string email, string firstName, string lastName)
        {
            this.id = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
