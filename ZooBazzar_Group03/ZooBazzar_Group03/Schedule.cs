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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

            EveningAnimals();
        }

        public void EveningAnimals()
        {
            MySqlConnection conn = new MySqlConnection("Server = studmysql01.fhict.local; Uid=dbi481796;Database=dbi481796;Pwd=sql7915");
            
            try
            {
                string sql = "SELECT Picture FROM animalpictures ap INNER JOIN feedingschedule fs ON ap.AnimalCode = fs.AnimalCode WHERE FeedingTime = 'evening';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AnimalPicture ap = new AnimalPicture();
                    panelEvening.Controls.Add(ap);
                    ap.GetPicture(reader.GetString("Picture"));
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
