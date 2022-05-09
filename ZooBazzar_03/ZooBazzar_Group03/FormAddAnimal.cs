using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class FormAddAnimal : Form
    {
        private AnimalManager animalManager = new AnimalManager(new AnimalDB());
        MainManu menu;
        List<string> feedingTimes = new List<string>();
        public FormAddAnimal(MainManu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMorning.Checked)
            {
                feedingTimes.Add("morning");
            }
            if (cbAfternoon.Checked)
            {
                feedingTimes.Add("aftermoon");
            }
            if (cbEvening.Checked)
            {
                feedingTimes.Add("evening");
            }
            animalManager.AddAnimal(tbAnimalCode.Text, tbName.Text, cbAnimalType.SelectedItem.ToString(), tbSpecie.Text, Convert.ToInt32(tbCageNumber.Text), tbBirthdate.Text, tbReasonForArrival.Text, tbYearOfArrival.Text, string.Empty, string.Empty, cbDiet.SelectedItem.ToString(), feedingTimes);
            menu.UpdateAnimals();
        }

        private void FormAddAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void FormAddAnimal_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(AnimalType)))
            {
                cbAnimalType.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(Diet)))
            {
                cbDiet.Items.Add(item);
            }
        }

        private void cbDailyFeeding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDailyFeeding.SelectedItem == "1")
            {
                feedingTimes.Clear();
                cbMorning.Visible = false;
                cbAfternoon.Visible = false;
                cbEvening.Visible = false;
            }
            else if (cbDailyFeeding.SelectedItem == "2")
            {
                feedingTimes.Clear();
                cbMorning.Visible = false;
                cbAfternoon.Visible = false;
                cbEvening.Visible = false;
            }
            else
            {
                feedingTimes.Add("morning");
                feedingTimes.Add("afternoon");
                feedingTimes.Add("evening");
            }
        }
    }
}
