using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ZooBazzar_Group03
{
    public class AnimalDB
    {
        MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");
        List<Animal> animals = new List<Animal>();
        /// <summary>
        /// Get animals from the database
        /// </summary>
        /// <returns>Returns a list of the animals in the database</returns>
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

        //instead of adding all the values, make it so the parameter is an animal. Pass it with "this" and then extract the values from it
       
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
                if (cmd.ExecuteNonQuery()==1)
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
                MySqlCommand cmd = new MySqlCommand();
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
    }
}
