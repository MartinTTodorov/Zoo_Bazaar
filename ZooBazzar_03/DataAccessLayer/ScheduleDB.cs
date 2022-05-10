﻿using System;
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
    public class ScheduleDB : IScheduleDB<DailySchedule>
    {
        private MySqlConnection conn;

        public ScheduleDB()
        {
            conn = ConnectionDB.GetConnection();
        }



        public bool Add(DailySchedule ds)
        {
            try
            {
                string sql = "INSERT INTO daily_feeding_schedule (Date, AnimalType, mainEmployeeFir, mainEmployeeSec, helperEmployee, TimeSlot) VALUES (@date, @type, @main1, @main2, @helper, @time);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("date", ds.Date);
                cmd.Parameters.AddWithValue("type", ds.Type.ToString());
                cmd.Parameters.AddWithValue("main1", ds.MainCaretakerFir.Id);
                cmd.Parameters.AddWithValue("main2", ds.MainCaretakerSec.Id);
                if (ds.HelpCaretaker != null)
                {
                    cmd.Parameters.AddWithValue("helper", ds.HelpCaretaker.Id);
                }
                else
                {
                    cmd.Parameters.AddWithValue("helper", DBNull.Value);
                }
               
                cmd.Parameters.AddWithValue("time", ds.TimeSlot);

                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"For regular users: Database problem\r\nFor software engineers: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public List<DailySchedule> Read(List<string> days)
        {
            try
            {
                string sql = $"SELECT dfs.AnimalType, dfs.Date, dfs.mainEmployeeFir, dfs.mainEmployeeSec, dfs.helperEmployee, e1.FirstName AS mainFirstName, e2.FirstName AS mainSecondName, e3.FirstName AS helperName, e1.WorkPosition, dfs.TimeSlot FROM daily_feeding_schedule AS dfs " +
                    $"INNER JOIN employee e1 ON dfs.mainEmployeeFir = e1.ID " +
                    $"INNER JOIN employee e2 ON dfs.mainEmployeeSec = e2.ID " +
                    $"LEFT JOIN employee e3 ON dfs.helperEmployee = e3.ID " +
                    $"WHERE Date = @date0 OR Date = @date1 OR Date = @date2 OR Date = @date3 OR Date = @date4 OR Date = @date5 OR Date = @date6 ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                for (int i = 0; i < days.Count; i++)
                {
                    cmd.Parameters.AddWithValue(("date" + $"{i}"), days[i]);
                }

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<DailySchedule> list = new List<DailySchedule>();


                while (reader.Read())
                {
                    Caretaker firstMain = new Caretaker(Convert.ToInt32(reader["mainEmployeeFir"]), reader["mainFirstName"].ToString(), (Specialization)Enum.Parse(typeof(Specialization), reader["WorkPosition"].ToString()));
                    Caretaker secondMain = new Caretaker(Convert.ToInt32(reader["mainEmployeeSec"]), reader["mainSecondName"].ToString(), (Specialization)Enum.Parse(typeof(Specialization), reader["WorkPosition"].ToString()));
                    Caretaker helper;

                    if (reader["helperEmployee"] == DBNull.Value)
                    {
                        helper = null;
                    }
                    else
                    {
                        helper = new Caretaker(Convert.ToInt32(reader["helperEmployee"]), reader["helperName"].ToString(), (Specialization)Enum.Parse(typeof(Specialization), reader["WorkPosition"].ToString()));
                    }

                    list.Add(new DailySchedule((AnimalType)Enum.Parse(typeof(AnimalType), reader["AnimalType"].ToString()), reader["Date"].ToString(), firstMain, secondMain, helper, reader["TimeSlot"].ToString()));
                }

                return list;
            }
            finally
            {
                conn.Close();
            }

        }



        public bool Update(DailySchedule ds)
        {
            try
            {
                string sql = "UPDATE daily_feeding_schedule SET mainEmployeeFir = @id1, mainEmployeeSec = @id2, helperEmployee = @id3 WHERE Date = @date AND TimeSlot = @time AND AnimalType = @type;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id1", ds.MainCaretakerFir.Id);
                cmd.Parameters.AddWithValue("id2", ds.MainCaretakerSec.Id);
                if (ds.HelpCaretaker == null)
                {
                    cmd.Parameters.AddWithValue("id3", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("id3", ds.HelpCaretaker.Id);
                }
                
                cmd.Parameters.AddWithValue("date", ds.Date);
                cmd.Parameters.AddWithValue("type", ds.Type.ToString());
                cmd.Parameters.AddWithValue("time", ds.TimeSlot);


                conn.Open();

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    return true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"For regular users: Database problem\r\nFor software engineers: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
