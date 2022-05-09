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
    public partial class fmDeleteAnimal : Form
    {
        Animal animal;
        AnimalManager animalManager = new AnimalManager(new AnimalDB());
        MainManu menu;
        public fmDeleteAnimal(Animal animal, MainManu menu)
        {
            InitializeComponent();
            this.animal = animal;
            this.menu = menu;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbReasonForDeparture.Text == String.Empty)
            {
                MessageBox.Show("Please specify a reason for removing the animal");
            }
            else
            {
                //animal.ReasonForDeparture = tbReasonForDeparture.Text;
                animalManager.DeleteAnimal(animal);
                menu.UpdateAnimals();
            }
        }

        private void fmDeleteAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
