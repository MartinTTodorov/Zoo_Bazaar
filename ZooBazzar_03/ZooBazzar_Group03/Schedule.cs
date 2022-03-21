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
        public Schedule(string date)
        {
            InitializeComponent();
            this.date = date;
            this.currentDate = DateTime.ParseExact(date, "dd MMM yyyy", null);
        }
        string date;

        AnimalDB db = new AnimalDB();

        DateTime currentDate;

        private void Schedule_Load(object sender, EventArgs e)
        {

            if (currentDate.CompareTo(DateTime.Today) == -1)
            {
                btnAssign.Enabled = false;
                btnEditEmployee.Enabled = false;
            }

        }

        


       
        public DataTable GetAnimals(string time)
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

                AnimalPicture ap = new AnimalPicture(animalCode, this, date);

                
                
                panelAnimals.Controls.Add(ap);
                ap.GetPicture(ms, name);
            }
            

            da.Dispose();

            return table;
        }

        private void cmbTimeSloth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeSloth.SelectedItem.ToString() == "6:00 - 8:00")
            {
                GetAnimals("morning");
            }

            if (cmbTimeSloth.SelectedItem.ToString() == "12:00 - 14:00")
            {
                GetAnimals("noon");
            }

            if (cmbTimeSloth.SelectedItem.ToString() == "20:00 - 22:00")
            {
                GetAnimals("evening");
            }

            lblAnimalType.Text = "";
            lblSpecies.Text = "";
            cmbEmployees.Items.Clear();
        }

        

        public void btnAssign_Click(object sender, EventArgs e)
        {
            if (db.Insert(lblAnimalCode.Text, date, cmbEmployees.SelectedIndex) > 0)
            {
                MessageBox.Show("Fortunately, thanks to my great coding skills you were able to successfully assign a caretaker to the animal");
                btnAssign.Enabled = false;
                btnEditEmployee.Enabled = true;    
            }
            else
            {
                MessageBox.Show("Unfortunately, under unknown circumstances you sadly didn't do anythyng useful!!!");
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (db.EditSpecialist(lblAnimalCode.Text, date, cmbEmployees.SelectedIndex) > 0)
            {
                MessageBox.Show("Fortunately, thanks to my great coding skills you were able to successfully edit the assigned caretaker to the animal");
            }
            else
            {
                MessageBox.Show("Unfortunately, under unknown circumstances you sadly didn't do anythyng useful!!!");
            }
        }
    }
}
