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
    public partial class FormAddAnimal : Form
    {
        private AnimalManager animalManager = new AnimalManager();
        public FormAddAnimal()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            animalManager.AddAnimal(tbAnimalCode.Text, tbName.Text, cbAnimalType.SelectedIndex.ToString(), tbSpecie.Text, Convert.ToInt32(tbCageNumber.Text), tbBirthdate.Text, tbReasonForArrival.Text, tbYearOfArrival.Text, tbYearOfDeparture.Text, tbReasonForDeparture.Text, cbDiet.SelectedIndex.ToString());
        }

        private void FormAddAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
