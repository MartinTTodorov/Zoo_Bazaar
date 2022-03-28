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
    public partial class AnimalPic : UserControl
    {
        private Animal animal;
        private AnimalManager animalManager = new AnimalManager();
        MainManu menu;
        string workposition;
        public AnimalPic(Animal animal, MainManu menu, string workposition)
        {
            InitializeComponent();
            this.animal = animal;
            this.menu = menu;
            this.workposition = workposition;
            if (workposition != "Manager")
            {
                btnRemoveAnimal.Visible = false;
            }
        }

        private void AnimalPic_Load(object sender, EventArgs e)
        {
            lblName.Text = animal.Name;
            if (animalManager.HasImage(animal))
            {
                MemoryStream ms = animalManager.GetMemoryStream(animal.AnimalCode);
                pbAnimal.Image = Image.FromStream(ms);
            }
        }

        private void pbAnimal_Click(object sender, EventArgs e)
        {
            if (workposition == "Manager")
            {
                AnimalInfo animalInfo = new AnimalInfo(animal);
                animalInfo.Show();

            }
        }

        private void btnRemoveAnimal_Click(object sender, EventArgs e)
        {
            fmDeleteAnimal deleteAnimal = new fmDeleteAnimal(this.animal, menu);
            deleteAnimal.Show();
        }
    }
}
