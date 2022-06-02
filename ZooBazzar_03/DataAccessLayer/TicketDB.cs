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
                    tickets.Add(new Ticket(Convert.ToInt32(reader["id"]), cdb.GetCustomer(Convert.ToInt32(reader["cust_id"])), (TypeOfTicket)Enum.Parse(typeof(TypeOfTicket), reader["typeTicket"].ToString()), Convert.ToDateTime(reader["dateOfPerchese"]), reader["placeOfPurchase"].ToString()));

                }
                return tickets;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
            return null;
        }
    }
}
