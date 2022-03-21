using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace ZooBazzar_Group03
{
    public partial class AnimalPicture : UserControl
    {
        public AnimalPicture()
        {
            InitializeComponent();


        }

        private Schedule schedule = null;
        public AnimalPicture(string code, Form callingForm, string date)
        {
            schedule = callingForm as Schedule;
            InitializeComponent();
            this.animalCode = code;
            this.date = date;
            this.currentDate = DateTime.ParseExact(date, "dd MMM yyyy", null);
        }

        

        AnimalDB db = new AnimalDB();

        string animalCode;

        string date;

        DateTime currentDate;


        private void pbAnimal_Click(object sender, EventArgs e)
        {
            schedule.lblAnimalType.Text = db.GetAnimalType(animalCode);
            schedule.lblSpecies.Text = db.GetSpecies(animalCode);
            schedule.lblAnimalCode.Text = animalCode;

            if (currentDate.CompareTo(DateTime.Today) > -1)
            {
                if (db.IsAnimalFed(date, animalCode) == 0)
                {
                    schedule.cmbEmployees.Text = "";
                    schedule.cmbEmployees.Items.Clear();
                    foreach (Specialist s in db.GetSpecialisedEmployees(animalCode))
                    {
                        schedule.cmbEmployees.Items.Add($"Employee: {s.Name} (ID: {s.EmployeeId})");
                    }
                    schedule.btnAssign.Enabled = true;
                    schedule.btnEditEmployee.Enabled = false;
                }
                else
                {
                    schedule.cmbEmployees.Items.Clear();
                    schedule.cmbEmployees.Text = $"Employee: {db.AssignedSpecialist(date, animalCode).Name} (ID: {db.AssignedSpecialist(date, animalCode).EmployeeId})";
                    foreach (Specialist s in db.GetSpecialisedEmployees(animalCode))
                    {
                        schedule.cmbEmployees.Items.Add($"Employee: {s.Name} (ID: {s.EmployeeId})");
                    }
                    schedule.btnAssign.Enabled = false;
                    schedule.btnEditEmployee.Enabled = true;
                }
            }
            else
            {
                schedule.cmbEmployees.Enabled = false;
                schedule.cmbEmployees.Text = "";

                if (db.IsAnimalFed(date, animalCode) != 0)
                {
                    schedule.cmbEmployees.Text = $"Employee: {db.AssignedSpecialist(date, animalCode).Name} (ID: {db.AssignedSpecialist(date, animalCode).EmployeeId})";
                }
                else
                {
                    schedule.cmbEmployees.Text = "Noone fed the poor animal!";
                }
            }

        }

        private void AnimalPicture_Load(object sender, EventArgs e)
        {

        }

        public void GetPicture(MemoryStream ms, string name)
        {
            pbAnimal.Image = Image.FromStream(ms);
            lblName.Text = name;
        }


    }
}
