using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace ZooBazzar_Group03
{
    public class ScheduleDB
    {
        public string GetSpecies(string animalCode)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT Species from animal WHERE AnimalCode = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", animalCode);
                conn.Open();

                Object species = cmd.ExecuteScalar();

                return species.ToString();
            }
            finally
            {

                conn.Close();
            }
        }

        public string GetAnimalType(string animalCode)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT AnimalType from animal WHERE AnimalCode = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", animalCode);
                conn.Open();

                Object type = cmd.ExecuteScalar();

                return type.ToString();
            }
            finally
            {

                conn.Close();
            }
        }


        public string GetSpecialisation(string animalCode)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT Specialist from feedingschedule WHERE AnimalCode = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", animalCode);
                conn.Open();

                Object type = cmd.ExecuteScalar();

                return type.ToString();
            }
            finally
            {

                conn.Close();
            }
        }

        public List<Specialist> GetSpecialisedEmployees(string animalCode)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT ID, FirstName from Employee WHERE WorkPosition = @spec";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("spec", GetSpecialisation(animalCode));
                conn.Open();


                List<Specialist> specialists = new List<Specialist>();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    specialists.Add(new Specialist(Convert.ToInt32(reader["ID"]), reader["FirstName"].ToString()));
                }


                return specialists;
            }
            finally
            {

                conn.Close();
            }
        }

        public int Insert(string animalCode, string date, int index)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "INSERT INTO daily_feeding_schedule (Date, AnimalCode, EmployeeId) VALUES (@date, @code, @id);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", animalCode);
                cmd.Parameters.AddWithValue("id", GetSpecialisedEmployees(animalCode)[index].EmployeeId);

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

        public int IsAnimalFed(string date, string animalCode)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT COUNT(AnimalCode) from daily_feeding_schedule WHERE Date = @date AND AnimalCode = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("code", animalCode);
                conn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    return count;
                }

            }
            finally
            {

                conn.Close();
            }
            return 0;
        }

        public Specialist AssignedSpecialist(string date, string animalCode)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT EmployeeId, FirstName from daily_feeding_schedule fs  INNER JOIN Employee e ON fs.EmployeeId = e.ID WHERE Date = @date AND AnimalCode = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("code", animalCode);
                conn.Open();


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return new Specialist(Convert.ToInt32(reader["EmployeeId"]), reader["FirstName"].ToString());
                }
            }
            finally
            {

                conn.Close();
            }
            return null;
        }


        public int EditSpecialist(string animalCode, string date, int index)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "INSERT INTO daily_feeding_schedule (Date, AnimalCode, EmployeeId) VALUES (@date, @code, @id);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", animalCode);
                cmd.Parameters.AddWithValue("id", GetSpecialisedEmployees(animalCode)[index].EmployeeId);

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

        public DataTable GetAnimals(string time, Panel panelAnimals, Form form, string date, DateTime currentDate)
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");
            MySqlCommand command;
            MySqlDataAdapter da;

            string selectQuery = "SELECT Picture, ap.AnimalCode, Name FROM animalpictures ap INNER JOIN feedingschedule fs ON ap.AnimalCode = fs.AnimalCode INNER JOIN animal a ON ap.AnimalCode = a.AnimalCode WHERE FeedingTime = @time;";

            command = new MySqlCommand(selectQuery, conn);

            command.Parameters.AddWithValue("time", time);

            da = new MySqlDataAdapter(command);


            DataTable table = new DataTable();
            da.Fill(table);

            panelAnimals.Controls.Clear();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                byte[] img = (byte[])table.Rows[i][0];

                MemoryStream ms = new MemoryStream(img);

                string name = table.Rows[i][2].ToString();

                string animalCode = table.Rows[i][1].ToString();

                if (IsAnimalHere(animalCode))
                {
                    AnimalPicture ap = new AnimalPicture(animalCode, form, date, currentDate);
                    panelAnimals.Controls.Add(ap);
                    ap.GetPicture(ms, name);
                }




            }


            da.Dispose();

            return table;
        }

        public bool IsAnimalHere(string animalCode)
        {

            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");

            try
            {
                string sql = "SELECT YearOfDeparture from animal WHERE AnimalCode = @code";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("code", animalCode);
                conn.Open();

                if (cmd.ExecuteScalar() != null)
                {
                    return true;
                }

                return true;
            }
            finally
            {

                conn.Close();
            }
            return false;
        }

    }
}
