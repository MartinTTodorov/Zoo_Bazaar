using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ZooBazzar_Group03
{
    public partial class AssignEmployee : Form
    {
        public AssignEmployee(string code)
        {
            InitializeComponent();

            this.animalCode = code;
            lblSpecies.Text += "  " + GetSpecies();
            lblAnimalType.Text += "  " + GetAnimalType();
        }

        string animalCode;

        public string GetSpecies()
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

        public string GetAnimalType()
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

        public string GetEmployees()
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

        private void AssignEmployee_Load(object sender, EventArgs e)
        {
            
        }
    }
}
