using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TicketDB : ITicketDB
    {
        private MySqlConnection conn;


        public TicketDB()
        {
            conn = ConnectionDB.GetConnection();
        }

        public List<Ticket> GetTickets()
        {
            string sql = "SELECT * from ticket";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            CustomerDB cdb = new CustomerDB();
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Ticket> tickets = new List<Ticket>();


                while (reader.Read())
                {
                    bool isUsed = Convert.ToBoolean(reader["isUsed"]);
                    TypeOfTicket typeOfTicket = (TypeOfTicket)Enum.Parse(typeof(TypeOfTicket), reader["typeTicket"].ToString());
                    tickets.Add(new Ticket(Convert.ToInt32(reader["id"]), cdb.GetCustomer(Convert.ToInt32(reader["cust_id"])), typeOfTicket, Convert.ToDateTime(reader["dateOfPerchese"]), reader["placeOfPurchase"].ToString(), isUsed));

                }
                return tickets;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {

                conn.Close();
            }
            return null;
        }

        public void ChangeTicketStatus(Ticket t)
        {
            string sql = "UPDATE ticket SET isUsed = @isUsed WHERE id = @id ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", t.Id);
            cmd.Parameters.AddWithValue("@isUsed", true);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        public Customer GetCustomer(string email)
        {
            try
            {
                string sql = "SELECT * FROM customer where email=@email";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@email", email);
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
