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
                cmd.Parameters.AddWithValue("cage", ds.Cage.CageNumber);
                cmd.Parameters.AddWithValue("id", ds.Employee.Id);
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
                string sql = $"SELECT * FROM `daily_feeding_schedule` WHERE Date = @date0 OR Date = @date1 OR Date = @date2 OR Date = @date3 OR Date = @date4 OR Date = @date5 OR Date = @date6 ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                for (int i = 0; i < days.Count; i++)
                {
                    cmd.Parameters.AddWithValue(("date" + $"{i}"), days );
                }

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<DailySchedule> list = new List<DailySchedule>();


                while (reader.Read())
                {
                    list.Add(new DailySchedule(new Cage(Convert.ToInt32(reader["CageNumber"])), reader["Date"].ToString(), new Caretaker(Convert.ToInt32(reader["EmployeeId"]), reader["FirstName"].ToString(), (Specialization)Enum.Parse(typeof(Specialization), reader["Specialization"].ToString())), reader["TimeSlot"].ToString()));
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
                cmd.Parameters.AddWithValue("id", ds.Employee.Id);
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
