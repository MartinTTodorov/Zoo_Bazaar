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
        public AnimalPic(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
        }

        private void AnimalPic_Load(object sender, EventArgs e)
        {
            lblName.Text = animal.Name;
            if (animalManager.HasImage(animal))
            {
                MemoryStream ms =  animalManager.GetMemoryStream(animal.AnimalCode);
                pbAnimal.Image = Image.FromStream(ms);
            }
        }

        private void pbAnimal_Click(object sender, EventArgs e)
        {
            AnimalInfo animalInfo = new AnimalInfo(animal);
            animalInfo.Show();
        }
    }
}
