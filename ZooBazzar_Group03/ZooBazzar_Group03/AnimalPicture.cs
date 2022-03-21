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
    public partial class AnimalPicture : UserControl
    {
        public AnimalPicture()
        {
            InitializeComponent();
        }

        private void pbAnimal_Click(object sender, EventArgs e)
        {

        }

        private void AnimalPicture_Load(object sender, EventArgs e)
        {

        }

        public void GetPicture(string command)
        {
            pbAnimal.Load(command);
        }
    }
}
