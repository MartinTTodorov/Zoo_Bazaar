using MySql.Data.MySqlClient;
using Entities;

namespace DataAccessLayer
{
    public class StatisticsDB : IStatistics
    {
        private MySqlConnection conn = ConnectionDB.GetConnection();

     
       public Dictionary<int, int> GetTicketSales(string filter, string place, string filter2, int value)
        {
            Dictionary<int, int> tickets = new Dictionary<int, int>();



            try
            {
                string sql = null;



                if (filter2 == null && value == 0)
                {
                    sql = $"SELECT {filter}(dateOfPerchese) as date, COUNT(*) as count FROM ticket WHERE placeOfPurchase = @place GROUP BY {filter}(dateOfPerchese);";
                }
                else
                {
                    sql = $"SELECT {filter}(dateOfPerchese) as date, COUNT(*) as count FROM ticket WHERE placeOfPurchase = @place AND {filter2}(dateOfPerchese) = {value} GROUP BY {filter}(dateOfPerchese);";
                }




                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("place", place);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();




                while (reader.Read())
                {
                    tickets.Add(Convert.ToInt32(reader["date"]), Convert.ToInt32(reader["count"]));
                }
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



            return tickets;
        }



        public Dictionary<int, double> GetIncome(string filter, string filter2, int value)
        {



            Dictionary<int, double> income = new Dictionary<int, double>();



            try
            {
                string sql = null;



                if (filter2 == null && value == 0)
                {
                    sql = $"SELECT {filter}(dateOfPerchese) as date, SUM(price) as sum FROM ticket GROUP BY {filter}(dateOfPerchese)";
                }
                else
                {



                    sql = $"SELECT {filter}(dateOfPerchese) as date, SUM(price) as sum FROM ticket WHERE {filter2}(dateOfPerchese) = {value} GROUP BY {filter}(dateOfPerchese)";
                }
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();




                while (reader.Read())
                {
                    income.Add(Convert.ToInt32(reader["date"]), Convert.ToInt32(reader["sum"]));
                }
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



            return income;




        }




        public Dictionary<int, int> GetPeople()
        {

            Dictionary<int, int> people = new Dictionary<int, int>();


            try
            {
                string sql = "SELECT HOUR(dateOfUse) as time, COUNT(*) as peopleCount FROM `ticket` WHERE dateOfUse IS NOT null GROUP BY HOUR(dateOfUse);";



                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    people.Add(Convert.ToInt32(reader["time"]), Convert.ToInt32(reader["peopleCount"]));
                }
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



            return people;



        }
    }
}
