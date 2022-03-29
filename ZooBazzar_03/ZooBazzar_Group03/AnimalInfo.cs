using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03
{
    public partial class AnimalInfo : Form
    {
        private Animal animal;
        AnimalManager animalManager = new AnimalManager();
        MainManu menu;
        public AnimalInfo(Animal animal, MainManu menu)
        {
            InitializeComponent();
            this.animal = animal;
            this.menu = menu;
        }

        private void AnimalInfo_Load(object sender, EventArgs e)
        {
            tbID.Text = animal.Id.ToString(); ;
            tbCageNumber.Text = animal.CageNumber.ToString();
            tbAnimalCode.Text = animal.AnimalCode;
            tbName.Text = animal.Name;
            tbSpecie.Text = animal.Specie;
            tbReasonForArrival.Text = animal.ReasonForArrival;
            tbYearOfArrival.Text = animal.YearOfArrival;
            tbBirthdate.Text = animal.Birthdate;
            foreach (var item in Enum.GetValues(typeof(AnimalType)))
            {
                cbAnimalType.Items.Add(item);
            }
            cbAnimalType.Text = animal.AnimalType.ToString();

            foreach (var item in Enum.GetValues(typeof(Diet)))
            {
                cbDiet.Items.Add(item);
            }
            cbDiet.Text = animal.Diet.ToString();
        }

        private void AnimalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Animal updatedAnimal = new Animal(tbAnimalCode.Text, Convert.ToInt32(tbID.Text), Convert.ToInt32(tbCageNumber.Text), tbName.Text, tbReasonForArrival.Text, string.Empty, (Diet)cbDiet.SelectedItem, (AnimalType)cbAnimalType.SelectedItem, tbSpecie.Text, tbYearOfArrival.Text, string.Empty, tbBirthdate.Text);
            animalManager.UpdateAnimal(updatedAnimal);
            menu.UpdateAnimals();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //animalManager.DeleteAnimalByID(animal.Id);
        }
    }
}
