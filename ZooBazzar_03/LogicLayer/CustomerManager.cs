using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class CustomerManager
    {
        ICustomerDB db;
        private List<Customer> customers;
        public CustomerManager(ICustomerDB db)
        {
            this.db = db;
            customers = db.GetCustomers();
        }

        public Customer GetCustomer(int id)
        {
            return customers.Find(x => x.Id == id);
        }

        



    }
}
