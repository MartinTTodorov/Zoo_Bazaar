﻿using System;
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
        public AnimalInfo(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
        }

        private void AnimalInfo_Load(object sender, EventArgs e)
        {
            tbID.Text = animal.Id.ToString(); ;
            tbCageNumber.Text = animal.CageNumber.ToString();
            tbAnimalCode.Text = animal.AnimalCode;
            tbName.Text = animal.Name;
            tbSpecie.Text = animal.Specie;
            tbReasonForArrival.Text = animal.ReasonForArrival;
            tbReasonForDeparture.Text = animal.ReasonForDeparture;
            tbYearOfArrival.Text = animal.YearOfArrival;
            tbYearOfDeparture.Text = animal.YearOfDeparture;
            tbBirthdate.Text = animal.Birthdate;
            foreach (var item in Enum.GetValues(typeof(AnimalType)))
            {
                cbAnimalType.Items.Add(item);
            }
            cbAnimalType.Text = animal.AnimalType.ToString();

            foreach (var item in Enum.GetValues(typeof(AnimalType)))
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
            Animal updatedAnimal = new Animal(tbAnimalCode.Text, Convert.ToInt32(tbID.Text), Convert.ToInt32(tbCageNumber.Text), tbName.Text, tbReasonForArrival.Text, tbReasonForDeparture.Text, (Diet)cbDiet.SelectedIndex, (AnimalType)cbAnimalType.SelectedIndex, tbSpecie.Text, tbYearOfArrival.Text, tbYearOfDeparture.Text, tbBirthdate.Text);
            animalManager.UpdateAnimal(updatedAnimal);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            animalManager.DeleteAnimalByID(animal.Id);
        }
    }
}