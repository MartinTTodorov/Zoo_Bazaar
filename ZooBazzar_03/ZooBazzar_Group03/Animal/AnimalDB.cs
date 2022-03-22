using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ZooBazzar_Group03
{
    public class AnimalDB
    {
        MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");
        List<Animal> animals = new List<Animal>();

        public List<Animal> GetAnimals()
        {
            try
            {
                string sql = "SELECT * from animal";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    animals.Add(new Animal(Convert.ToString(reader["AnimalCode"]), Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["CageNumber"]), reader["Name"].ToString(), reader["ReasonForArrival"].ToString(), reader["ReasonOFDeparture"].ToString(), (Diet)Enum.Parse(typeof(Diet), reader["Diet"].ToString()), (AnimalType)Enum.Parse(typeof(AnimalType), reader["AnimalType"].ToString()), reader["Species"].ToString(), reader["YearOfArrival"].ToString(), reader["YearOfDeparture"].ToString(), reader["Birthdate"].ToString()));
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
            return animals;
        }

        public void AddAnimalToDB(string animalCode, string name, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet)
        {
            try
            {
                string sql = "INSERT INTO animal (AnimalCode, Name, AnimalType, Species, CageNumber, Birthdate, ReasonForArrival, YearOfArrival, YearOfDeparture, ReasonForDeparture, Diet) VALUES(@animalCode, @name, @animalType, @species, @cageNumber, @birthdate, @reasonForArrival, @yearOfArrival, @yearOfDeparture, @reasonForDeparture, @diet);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@animalCode", animalCode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@animalType", animalType);
                cmd.Parameters.AddWithValue("@species", species);
                cmd.Parameters.AddWithValue("@cageNumber", cageNumber);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@reasonForArrival", reasonForArrival);
                cmd.Parameters.AddWithValue("@yearOfArrival", yearOfArrival);
                cmd.Parameters.AddWithValue("@yearOfDeparture", yearOfDeparture);
                cmd.Parameters.AddWithValue("@reasonForDeparture", reasonForDeparture);
                cmd.Parameters.AddWithValue("@diet", diet);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New animal has been added");
                }
                else
                {
                    MessageBox.Show("Failed to add a new animal");
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

        }


        public void UpdateAnimalInDB(string animalCode, string name, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, int id)
        {
            try
            {
                string sql = "UPDATE animal set AnimalCode=@animalCode, Name=@name, AnimalType=@animalType, Species=@species, CageNumber=@cageNumber, Birthdate=@birthdate, ReasonForArrival=@reasonForArrival, YearOfArrival = @yearOfArrival, YearOfDeparture=@yearOfDeparture, ReasonForDeparture=@reasonForDeparture, Diet=@diet WHERE id=@id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@animalCode", animalCode);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@animalType", animalType);
                cmd.Parameters.AddWithValue("@species", species);
                cmd.Parameters.AddWithValue("@cageNumber", cageNumber);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@reasonForArrival", reasonForArrival);
                cmd.Parameters.AddWithValue("@yearOfArrival", yearOfArrival);
                cmd.Parameters.AddWithValue("@yearOfDeparture", yearOfDeparture);
                cmd.Parameters.AddWithValue("@reasonForDeparture", reasonForDeparture);
                cmd.Parameters.AddWithValue("@diet", diet);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New animal has been added");
                }
                else
                {
                    MessageBox.Show("Failed to add a new animal");
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
        }




        public void DeleteAnimalFromDB(int id)
        {
            try
            {
                string sql = "DELETE FROM animal WHERE id=@id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Animal has been deleted from the database");
                }
                else
                {
                    MessageBox.Show("Failed to delete the animal from the database");
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

        }
        public bool HasImage(string animalCode)
        {
            string sql = "SELECT Picture, ap.AnimalCode FROM animalpictures ap INNER JOIN animal a ON ap.AnimalCode = a.AnimalCode WHERE ap.AnimalCode = @animalCode;";

            //string sql = "SELECT Picture FROM animalpictures WHERE EXISTS(SELECT Picture FROM animalpictures ap INNER JOIN animal a on a.AnimalCode=ap.AnimalCode WHERE a.AnimalCode = @animalCode;)"
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@animalCode", animalCode);
            if (cmd.ExecuteScalar()==null)
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
        }

        public MemoryStream GetMemoryStream(string animalCode)
        {
            string sql = "SELECT Picture, ap.AnimalCode FROM animalpictures ap INNER JOIN animal a ON ap.AnimalCode = a.AnimalCode WHERE ap.AnimalCode = @animalCode;";
            MySqlCommand cmd;
            MySqlDataReader dr;

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@animalCode", animalCode);

            conn.Open();

            byte[] img = (byte[])cmd.ExecuteScalar();
            MemoryStream ms = new MemoryStream(img);
            conn.Close();
            return ms;

        }





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
    }
}
