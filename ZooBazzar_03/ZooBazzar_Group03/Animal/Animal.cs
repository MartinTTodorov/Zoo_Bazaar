using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class Animal
    {
        private string id;
        private int cageNumber;
        private string name;
        private string reasonForArrival;
        private string reasonForDeparture;
        private Diet diet;
        private AnimalType type;
        private string specie;
        private string yearOfArrival;
        private string yearOfDeparture;
        private string birthDate;
        private DateTime feedingTime;

        public string Id { get { return id; } }

       
        public int CageNumber { get { return cageNumber; } set { cageNumber = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Specie { get { return specie; } set { specie = value; } }

        public Diet Diet { get { return diet; } set { diet = value; } }

        public Animal(string id, int cageNumber, string name, string reasonForArrival, string reasonForDeparture, Diet diet, AnimalType type, string specie, string yearOfArrival, string yearOfDeparture, string birthdate)
        {
            this.id = id;
            this.cageNumber = cageNumber;
            this.name = name;
            this.reasonForArrival = reasonForArrival;
            this.reasonForDeparture = reasonForDeparture;
            this.diet = diet;
            this.type = type;
            this.specie = specie;
            this.yearOfArrival = yearOfArrival;
            this.yearOfDeparture = yearOfDeparture;
            this.birthDate = birthdate;
        }

        public string GetInfo()
        {
            return $"id: {this.id}, name:{this.name}";
        }
    }
}
