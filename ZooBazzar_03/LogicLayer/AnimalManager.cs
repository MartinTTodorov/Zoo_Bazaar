using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class AnimalManager
    {
        //Fields
        private IAnimalDB<Animal> crud;
        private List<Animal> animals;

        public IList<Animal> Animals { get { return animals.AsReadOnly(); } }

        //Constructor
        public AnimalManager(IAnimalDB<Animal> crud)
        {
            this.crud = crud;
            animals = crud.GetAnimals();
        }

        //Methods
        public void AddAnimal(string animalCode, string name, string gender, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, List<string> feedingTimes, string specialist, int weeklyFeedingIteration)
        {
          //  crud.AddAnimalToDB(new Animal(animalCode, name, gender, animalType, species, cageNumber, birthdate, reasonForArrival, yearOfArrival, yearOfDeparture, reasonForDeparture, diet, feedingTimes, specialist, weeklyFeedingIteration);
            //UpdateLocalList();
        }

        public void UpdateAnimal(Animal animal)
        {
            if (System.Enum.IsDefined(typeof(AnimalType), animal.AnimalType))
            {
               
            }
          //  crud.UpdateAnimalInDB(animal.AnimalCode, animal.Name, animal.AnimalType.ToString(), animal.Specie, animal.CageNumber, animal.Birthdate, animal.ReasonForArrival, animal.YearOfArrival, animal.YearOfDeparture, animal.ReasonForDeparture, animal.Diet.ToString(), animal.Id);
            //UpdateLocalList();
        }


        public bool UpdateAnimals(Animal animal)
        {
            if (System.Enum.IsDefined(typeof(AnimalType), animal.AnimalType))
            {
                return false;
            }
            else
            {
               // crud.UpdateAnimalInDB(animal.AnimalCode, animal.Name, animal.AnimalType.ToString(), animal.Specie, animal.CageNumber, animal.Birthdate, animal.ReasonForArrival, animal.YearOfArrival, animal.YearOfDeparture, animal.ReasonForDeparture, animal.Diet.ToString(), animal.Id);
                return true;
            }
            //UpdateLocalList();
        }

        public void DeleteAnimal(Animal animal)
        {
            crud.DeleteAnimalFromDB(animal.Id, animal.ReasonForDeparture);
            //UpdateLocalList();
        }

        public void DeleteAnimalByID(int id)
        {
            //animalDB.DeleteAnimalFromDB(id);
            //UpdateLocalList();
        }

        public bool HasImage(Animal animal) //check against the animal code in the database directly in the animalpictures table. If true, run a query where animal code is this animal code and get the memory stream
        {
            if (crud.HasImage(animal.AnimalCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MemoryStream GetMemoryStream(string animalCode)
        {
            return crud.GetMemoryStream(animalCode);
        }

        public void AssignFeedingTimes()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].FeedingTimes = crud.GetFeeding(animals[i]);
            }
        }

        public void AssignNotes(Animal animal)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animal.Notes = crud.GetNotes(animal);
            }
        }

        public void AddNote(int id, string note)
        {
            crud.AddNote(id, note);
        }


        public List<Animal> GetAnimalsByType(AnimalType type)
        {
            List<Animal> typeAnimals = new List<Animal>();
            foreach (Animal animal in Animals)
            {
                if (animal.AnimalType==type)
                {
                    typeAnimals.Add(animal);
                }
            }
            return typeAnimals;
        }
    }
}
