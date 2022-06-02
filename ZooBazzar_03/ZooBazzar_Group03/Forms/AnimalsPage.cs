﻿using Entities;

namespace ZooBazzar_Group03.Forms
{
    public partial class AnimalsPage : Form
    {
        //Fields
        private List<Animal> animals;
        private string workingPosition;

        //Constructor
        public AnimalsPage(List<Animal> animals, string workingPosition)
        {
            InitializeComponent();

            this.animals = animals;
            this.workingPosition = workingPosition;
        }

        //Methods
        private void updateUXAnimals(List<Animal> animals)
        {
            flpAnimals.Controls.Clear();

            foreach (Animal animal in animals)
            {
                if (animal.ReasonForDeparture == String.Empty)
                {
                    AnimalPic animalPic = new AnimalPic(animal, workingPosition,flpAnimals);
                    flpAnimals.Controls.Add(animalPic);
                }
            }
        }

        //Events
        private void btnShowAllAnimals_Click(object sender, EventArgs e)
        {
            updateUXAnimals(animals);
        }

        private void btnAnimalName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAnimalName.Text))
                updateUXAnimals(animals.FindAll(a => a.Name.Contains(tbAnimalName.Text)));
        }

        private void btnFilterByType_Click(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(AnimalType), cbAnimalType.SelectedItem))
                updateUXAnimals(animals.FindAll(a => a.AnimalType == (AnimalType)cbAnimalType.SelectedItem));
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            FormAddAnimal frmAddAnimal = new FormAddAnimal(this.flpAnimals);
            frmAddAnimal.Show();
        }
    }
}