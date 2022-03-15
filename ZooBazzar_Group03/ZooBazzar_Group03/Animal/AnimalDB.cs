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

        public List<Animal> GetAnimals()
        {
            string sql = "SELECT * from animal";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Animal> animals = new List<Animal>();

            while (reader.Read())
            {
                animals.Add(new Animal(Convert.ToString(reader["AnimalCode"]), Convert.ToInt32(reader["CageNumber"]), reader["Name"].ToString(), reader["ReasonForArrival"].ToString(), reader["ReasonOFDeparture"].ToString(), (Diet)Enum.Parse(typeof(Diet), reader["Diet"].ToString()), (AnimalType)Enum.Parse(typeof(AnimalType), reader["AnimalType"].ToString()), reader["Species"].ToString(), reader["YearOfArrival"].ToString(), reader["YearOfDeparture"].ToString(), reader["Birthdate"].ToString()));
            }
            conn.Close();
            return animals;
        }
    }
}
