using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class AnimalDBMock : IAnimalDB<Animal>
    {
        public void AddAnimalToDB(string animalCode, string name, string gender, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, List<string> feedingTimes, string specialist, int weeklyFeedingIteration)
        {

        }

        public void DeleteAnimalFromDB(int id, string reasonForDeparture)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();
            //animals.Add(new Animal("kod1", 1, 1, "Viktor", "Male", "Born", null, Diet.Carnivore, AnimalType.Mammal, "Lion", "2020", null, "2019-05-15", Specialization.Mammalogist, null, 3));
            //animals.Add(new Animal("kod2", 2, 2, "Petar", "Male", "Born", null, Diet.Carnivore, AnimalType.Mammal, "Giraffe", "2020", null, "2019-05-15", Specialization.Mammalogist, null, 3));
            //animals.Add(new Animal("kod3", 3, 3, "Trendafil", "Male", "Born", null, Diet.Carnivore, AnimalType.Mammal, "Big giraffe", "2020", null, "2019-05-15", Specialization.Mammalogist, null, 3));
            return animals;
        }

        public List<string> GetFeeding(Animal animal)
        {
            //if (animal.Id == 1)
            //{
            //    animal.FeedingTimes.Add("Morning");
            //    animal.FeedingTimes.Add("Afternoon");
            //}
            //else if (animal.Id == 2)
            //{
            //    animal.FeedingTimes.Add("Morning");
            //}
            //else if (animal.Id == 3)
            //{
            //    animal.FeedingTimes.Add("Morning");
            //    animal.FeedingTimes.Add("Evening");
            //}
            //return animal.FeedingTimes;

            return new List<string>();
        }

        public MemoryStream GetMemoryStream(string animalCode)
        {
            throw new NotImplementedException();
        }

        public bool HasImage(string animalCode)
        {
            throw new NotImplementedException();
        }

        public void UpdateAnimalInDB(string animalCode, string name, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, int id)
        {
            throw new NotImplementedException();
        }
    }
}
