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
        private List<string> feedingTimes;

        private FlowLayoutPanel panel;
        public FormAddAnimal(FlowLayoutPanel panel)
        {
            InitializeComponent();

            this.panel = panel;            
            this.feedingTimes = new List<string>();
            this.cbGender.DataSource = new string[] { "Male", "Female" };
                       
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
            // tbAnimalCode.Text, tbName.Text, cbGender.SelectedItem.ToString(), cbAnimalType.SelectedItem.ToString(), tbSpecie.Text, Convert.ToInt32(tbCageNumber.Text), tbBirthdate.Text, tbReasonForArrival.Text, tbYearOfArrival.Text, string.Empty, string.Empty, cbDiet.SelectedItem.ToString(), feedingTimes, cbSpecialist.SelectedItem.ToString(), Convert.ToInt32(tbWeeklyFeedIteration.Text
            Animal animal = new Animal();
            animalManager.AddAnimal(tbAnimalCode.Text, tbName.Text, cbGender.SelectedItem.ToString(), cbAnimalType.SelectedItem.ToString(), tbSpecie.Text, Convert.ToInt32(tbCageNumber.Text), tbBirthdate.Text, tbReasonForArrival.Text, tbYearOfArrival.Text, string.Empty, string.Empty, cbDiet.SelectedItem.ToString(), feedingTimes, cbSpecialist.SelectedItem.ToString(), Convert.ToInt32(tbWeeklyFeedIteration.Text));
            //panel.Controls.Add(new AnimalPic())
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
            foreach (var item in Enum.GetValues(typeof(Specialization)))
            {
                cbSpecialist.Items.Add(item);
            }
        }

        
    }
}
