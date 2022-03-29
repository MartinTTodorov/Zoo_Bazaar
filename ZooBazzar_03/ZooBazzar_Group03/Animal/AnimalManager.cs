using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class AnimalManager
    {
        public List<Animal> animals;
        AnimalDB animalDB = new AnimalDB();

        public AnimalManager()
        {
            animals = animalDB.GetAnimals();
        }



        public void GetAnimalsFromDB()
        {
            if (animals != null) //if the list isn't empty
            {
                animals.Clear();
            }
            animals = animalDB.GetAnimals();
        }

        public void UpdateLocalList()
        {
            GetAnimalsFromDB();
        }
        public void AddAnimal(Animal animal)
        {
            animalDB.AddAnimalToDB(animal.AnimalCode, animal.Name, animal.AnimalType.ToString(), animal.Specie, animal.CageNumber, animal.Birthdate, animal.ReasonForArrival, animal.YearOfArrival, animal.YearOfDeparture, animal.ReasonForDeparture, animal.Diet.ToString());
            //UpdateLocalList();

        }

        public void AddAnimal(string animalCode, string name, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet)
        {
            animalDB.AddAnimalToDB(animalCode, name, animalType, species, cageNumber, birthdate, reasonForArrival, yearOfArrival, yearOfDeparture, reasonForDeparture, diet);
            //UpdateLocalList();
        }

        public void UpdateAnimal(Animal animal)
        {
            animalDB.UpdateAnimalInDB(animal.AnimalCode, animal.Name, animal.AnimalType.ToString(), animal.Specie, animal.CageNumber, animal.Birthdate, animal.ReasonForArrival, animal.YearOfArrival, animal.YearOfDeparture, animal.ReasonForDeparture, animal.Diet.ToString(), animal.Id);
            //UpdateLocalList();
        }

        public void DeleteAnimal(Animal animal)
        {
            animalDB.DeleteAnimalFromDB(animal.Id, animal.ReasonForDeparture);
            //UpdateLocalList();
        }

        public void DeleteAnimalByID(int id)
        {
            //animalDB.DeleteAnimalFromDB(id);
            //UpdateLocalList();
        }

        public bool HasImage(Animal animal) //check against the animal code in the database directly in the animalpictures table. If true, run a query where animal code is this animal code and get the memory stream
        {
            if (animalDB.HasImage(animal.AnimalCode))
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
            return animalDB.GetMemoryStream(animalCode);
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
