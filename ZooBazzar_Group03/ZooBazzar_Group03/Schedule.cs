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
using System.IO;

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
            GetAnimals("evening", panelEvening);
            GetAnimals("morning", panelMorning);
            GetAnimals("noon", panemNoon);
        }

       
        public DataTable GetAnimals(string time, Panel panel)
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

            for (int i = 0; i < table.Rows.Count; i++)
            {
                byte[] img = (byte[])table.Rows[i][0];

                MemoryStream ms = new MemoryStream(img);

                string name = table.Rows[i][2].ToString();

                string animalCode = table.Rows[i][1].ToString();

                AnimalPicture ap = new AnimalPicture(animalCode);

                panel.Controls.Add(ap);
                ap.GetPicture(ms, name);
            }
            

            da.Dispose();

            return table;
        }

    }
}
