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
using LogicLayer;
using Entities;
using DataAccessLayer;

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

        ScheduleDB db = new ScheduleDB();

        DateTime currentDate;

        private void Schedule_Load(object sender, EventArgs e)
        {
            if (currentDate.CompareTo(DateTime.Today) == -1)
            {
                btnAssign.Enabled = false;
                btnEditEmployee.Enabled = false;
            }

        }

        private void cmbTimeSloth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeSloth.SelectedIndex > -1)
            {
                string time = cmbTimeSloth.SelectedItem.ToString();
                if (time == "6:00 - 8:00")
                {
                    db.GetAnimals("morning", panelAnimals, this, date, currentDate);
                }

                if (time == "12:00 - 14:00")
                {
                    db.GetAnimals("noon", panelAnimals, this, date, currentDate);
                }

                if (time == "20:00 - 22:00")
                {
                    db.GetAnimals("evening", panelAnimals, this, date, currentDate);
                }

                lblAnimalType.Text = "";
                lblSpecies.Text = "";
                cmbEmployees.Items.Clear();

            }
        }



        public void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbEmployees.SelectedIndex > -1)
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
            else
            {
                MessageBox.Show("Choose an employee!!!");
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
