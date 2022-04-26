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



        public int Add(DailySchedule ds)
        {
            try
            {
                string sql = "INSERT INTO daily_feeding_schedule (Date, CageNumber, EmployeeId, TimeSlot) VALUES (@date, @cage, @id, @time);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("cage", ds.CageNumber);
                cmd.Parameters.AddWithValue("id", ds.EmployeeId);
                cmd.Parameters.AddWithValue("date", ds.Date);
                cmd.Parameters.AddWithValue("time", ds.TimeSlot);

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

        public List<DailySchedule> Read(List<string> days)
        {
            try
            {
                string sql = "SELECT * FROM `daily_feeding_schedule` WHERE Date = @date OR Date = @date OR Date = @date OR Date = @date OR Date = @date OR Date = @date OR Date = @date ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                foreach (string date in days)
                {
                    cmd.Parameters.AddWithValue("date", date);

                }

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<DailySchedule> list = new List<DailySchedule>();


                while (reader.Read())
                {
                    list.Add(new DailySchedule(Convert.ToInt32(reader["CageNumber"]), reader["Date"].ToString(), Convert.ToInt32(reader["EmployeeId"]), reader["TimeSlot"].ToString()));
                }

                return list;
            }
            finally
            {
                conn.Close();
            }

        }



        public int EditSpecialist(DailySchedule ds)
        {

            try
            {
                string sql = "UPDATE daily_feeding_schedule SET EmployeeId = @id WHERE Date = @date AND TimeSlot = @time;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ds.EmployeeId);
                cmd.Parameters.AddWithValue("date", ds.Date);
                cmd.Parameters.AddWithValue("time", ds.TimeSlot);


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




    }
}
