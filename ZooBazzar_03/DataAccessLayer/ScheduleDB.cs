using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using System.IO;
using System.Data;
using Entities;


namespace DataAccessLayer
{
    public class ScheduleDB
    {
        private MySqlConnection conn;

        public ScheduleDB()
        {
            conn = ConnectionDB.GetConnection();
        }

       
      

        public int Insert(string cageNumber, string date, int index)
        {

            try
            {
                string sql = "INSERT INTO daily_feeding_schedule (Date, CageNumber, EmployeeId) VALUES (@date, @cage, @id);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("cage", cageNumber);
                //cmd.Parameters.AddWithValue("id", );

                cmd.Parameters.AddWithValue("date", date);

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"For regular users: Database problem\r\nFor software engineers: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public List<DailySchedule> GetSchedules(string date)
        {
            try
            {
                string sql = "SELECT * from daily_feeding_schedule WHERE Date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("date", date);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<DailySchedule> list = new List<DailySchedule>();


                while (reader.Read())
                {
                    list.Add(new DailySchedule(Convert.ToInt32(reader["CageNumber"]), reader["Date"].ToString(), Convert.ToInt32(reader["EmployeeId"])));
                }

                return list;
            }
            finally 
            {
                conn.Close();
            }
            
        }



        public int EditSpecialist(int cageNr, string date, int index)
        {

            try
            {
                string sql = "INSERT INTO daily_feeding_schedule (Date, CageNumber, EmployeeId) VALUES (@date, @code, @id);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", cageNr);
                //cmd.Parameters.AddWithValue("id", GetSpecialisedEmployees(animalCode)[index].EmployeeId);

                cmd.Parameters.AddWithValue("date", date);

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"For regular users: Database problem\r\nFor software engineers: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public DataTable GetAnimals(string time)
        {
            MySqlCommand command;
            MySqlDataAdapter da;

            string selectQuery = "SELECT Picture, a.CageNumber FROM animalpictures ap INNER JOIN animal a ON ap.AnimalCode = a.AnimalCode WHERE FeedingTime = @time GROUP BY a.CageNumber;";

            command = new MySqlCommand(selectQuery, conn);

            command.Parameters.AddWithValue("time", time);

            da = new MySqlDataAdapter(command);

            try
            {
                DataTable table = new DataTable();
                da.Fill(table);

                return table;
            }
            finally 
            {
                da.Dispose();
                conn.Close();

            }
        }


    }
}
