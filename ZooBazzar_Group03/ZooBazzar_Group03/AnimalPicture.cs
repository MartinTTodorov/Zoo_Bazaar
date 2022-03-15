using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ZooBazzar_Group03
{
    public partial class AnimalPicture : UserControl
    {
        public AnimalPicture(string code)
        {
            InitializeComponent();

            this.animalCode = code;
        }

        string animalCode;

        private void pbAnimal_Click(object sender, EventArgs e)
        {
            AssignEmployee assignEmployee = new AssignEmployee(animalCode);
            assignEmployee.ShowDialog();
        }

        private void AnimalPicture_Load(object sender, EventArgs e)
        {

        }

        public void GetPicture(MemoryStream ms, string name)
        {
            pbAnimal.Image = Image.FromStream(ms);
            lblName.Text = name;
        }
    }
}
