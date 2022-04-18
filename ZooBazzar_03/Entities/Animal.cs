using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Animal
    {
        private int id; //
        private int cageNumber; //
        private string animalCode; //
        private string name; //
        private string gender;
        private string reasonForArrival;
        private string reasonForDeparture;
        private Diet diet; //
        private AnimalType type; //
        private string specie; //
        private string yearOfArrival;
        private string yearOfDeparture;
        private string birthDate;
        private string feedingTime;
        private Specialization specialization;
        int weeklyFeedingIteration;
        List<string> feedingTimes = new List<string>();

        public int Id { get { return id; } }

       
        public int CageNumber { get { return cageNumber; } }
        public string Name { get { return name; } }
        public string Gender { get { return gender; } }
        public string Specie { get { return specie; } }
        public string AnimalCode { get { return animalCode; } }
        public string Birthdate { get { return birthDate; } }
        public string ReasonForArrival { get { return reasonForArrival; } }
        public string YearOfArrival { get { return yearOfArrival; } }
        public string YearOfDeparture { get { return yearOfDeparture; } }
        public string ReasonForDeparture { get { return reasonForDeparture; } }
        public string FeddingTime { get { return feedingTime; } }
        public List<string> FeedingTimes { get { return feedingTimes; } set { feedingTimes = value; } }

        public Diet Diet { get { return diet; } set { diet = value; } }
        public AnimalType AnimalType { get { return type; } set { type = value; } }
        public int WeeklyFeedingIteration{ get { return weeklyFeedingIteration; } set { weeklyFeedingIteration = value; } }

        public Animal(string animalCode, int id, int cageNumber, string name, string gender, string reasonForArrival, string reasonForDeparture, Diet diet, AnimalType type, string specie, string yearOfArrival, string yearOfDeparture, string birthdate, string feedingTime)
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
            this.gender = gender;
            this.feedingTime = feedingTime;
        }

        public Animal(string animalCode,int cageNumber,  Diet diet, AnimalType type, string specie, List<string> feedingTimes, int weeklyFeedingIteration)
        {
            this.cageNumber = cageNumber;
            this.diet = diet;
            this.type = type;
            this.specie = specie;
            this.animalCode = animalCode;
            this.WeeklyFeedingIteration = weeklyFeedingIteration;
        }

        public string GetInfo()
        {
            return $"id: {this.id}, name:{this.name}";
        }
    }
}
