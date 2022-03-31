using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class Animal
    {
        private int id; //
        private int cageNumber; //
        private string animalCode; //
        private string name; //
        private string reasonForArrival;
        private string reasonForDeparture;
        private Diet diet; //
        private AnimalType type; //
        private string specie; //
        private string yearOfArrival;
        private string yearOfDeparture;
        private string birthDate;
        private DateTime feedingTime;

        public int Id { get { return id; } }

       
        public int CageNumber { get { return cageNumber; } set { cageNumber = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Specie { get { return specie; } set { specie = value; } }
        public string AnimalCode { get { return animalCode; } set { animalCode = value; } }
        public string Birthdate { get { return birthDate; } set { birthDate = value; } }
        public string ReasonForArrival { get { return reasonForArrival; } set { reasonForArrival = value; } }
        public string YearOfArrival { get { return yearOfArrival; } set { yearOfArrival = value; } }
        public string YearOfDeparture { get { return yearOfDeparture; } set { yearOfDeparture = value; } }
        public string ReasonForDeparture { get { return reasonForDeparture; } set { reasonForDeparture = value; } }

        public Diet Diet { get { return diet; } set { diet = value; } }
        public AnimalType AnimalType { get { return type; } set { type = value; } }

        public Animal(string animalCode, int id, int cageNumber, string name, string reasonForArrival, string reasonForDeparture, Diet diet, AnimalType type, string specie, string yearOfArrival, string yearOfDeparture, string birthdate)
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
            this.animalCode = animalCode;
        }

        public string GetInfo()
        {
            return $"id: {this.id}, name:{this.name}";
        }
    }
}
