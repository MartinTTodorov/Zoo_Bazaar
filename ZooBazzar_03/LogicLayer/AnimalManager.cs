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
        private List<Animal> animals;

        public List<Animal> Animals { get { return animals; } }
        IAnimalDB<Animal> crud;
        public AnimalManager(IAnimalDB<Animal> crud)
        {
            this.crud = crud;
            animals = crud.GetAnimals();
            //AssignFeedingTimes();
            //AssignNotes();
        }



        public void GetAnimalsFromDB()
        {
            if (animals != null) //if the list isn't empty
            {
                animals.Clear();
            }
            animals = crud.GetAnimals();
            //AssignFeedingTimes();
            //AssignNotes();
        }

        public void UpdateLocalList()
        {
            GetAnimalsFromDB();
        }
        public void AddAnimal(Animal animal)
        {
            //crud.AddAnimalToDB(animal.AnimalCode, animal.Name, animal.Gender, animal.AnimalType.ToString(), animal.Specie, animal.CageNumber, animal.Birthdate, animal.ReasonForArrival, animal.YearOfArrival, animal.YearOfDeparture, animal.ReasonForDeparture, animal.Diet.ToString(), animal.FeedingTimes);
            //UpdateLocalList();

        }

        public void AddAnimal(string animalCode, string name, string gender, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, List<string> feedingTimes, string specialist, int weeklyFeedingIteration)
        {
            crud.AddAnimalToDB(animalCode, name, gender, animalType, species, cageNumber, birthdate, reasonForArrival, yearOfArrival, yearOfDeparture, reasonForDeparture, diet, feedingTimes, specialist, weeklyFeedingIteration);
            //UpdateLocalList();
        }

        public void UpdateAnimal(Animal animal)
        {
            crud.UpdateAnimalInDB(animal.AnimalCode, animal.Name, animal.AnimalType.ToString(), animal.Specie, animal.CageNumber, animal.Birthdate, animal.ReasonForArrival, animal.YearOfArrival, animal.YearOfDeparture, animal.ReasonForDeparture, animal.Diet.ToString(), animal.Id);
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





        //public void AddAnimal(Animal animal)
        //{
        //    if (!animals.Any(a => a.Id == animal.Id))
        //    {
        //        animals.Add(animal);
        //    }
        //}

        //public void MoveAnimal(string id, int newCage)
        //{
        //    Animal animal = FindAnimal(id);

        //    if (animal != null)
        //    {
        //        animal.CageNumber = newCage;
        //    }
        //}

        //public void RemoveAnimal(string id)
        //{
        //    Animal animal = FindAnimal(id);


        //    if (animal != null)
        //    {
        //        animals.Remove(animal);
        //    }

        //}

        //private Animal FindAnimal(string id)
        //{
        //    return animals.Find(a => a.Id == id);
        //}


    }
}
