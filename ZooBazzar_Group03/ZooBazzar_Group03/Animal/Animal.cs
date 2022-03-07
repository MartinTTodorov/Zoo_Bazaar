using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03.Animal
{
    public class Animal
    {
        private int id;
        private int cageNumber;
        private string name;
        private string reasonForDeparture;
        private string location;
        private Diet diet;
        private AnimalType type;
        private DateTime yearOfArrival;
        private DateTime yearOfDeparture;
        private DateTime birthDate;
        private DateTime feedingTime;

        public int Id { get { return id; } }

        public string Location { get { return location; } set { location = value; } }
        public int CageNumber { get { return cageNumber; } set { cageNumber = value; } }

        //git checkout -b"Radi"

    }
}
