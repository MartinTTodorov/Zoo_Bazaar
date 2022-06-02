using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDB
    {
        private MySqlConnection conn;

        public CustomerDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        public Customer GetCustomer(int id)
        {
            try
            {
                string sql = "SELECT * FROM customer where id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                Customer customer;
                while (reader.Read())
                {
                    customer = new Customer(Convert.ToInt32(reader["id"]), reader["email"].ToString(), reader["firstname"].ToString(), reader["lastname"].ToString());
                    return customer;
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {

                conn.Close();
            }
            return null;
        }
    }
}
