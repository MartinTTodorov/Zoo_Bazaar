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
        public void AddAnimal(Animal animal)
        {
            crud.AddAnimalToDB(animal);
        }

        public void UpdateAnimal(Animal animal)
        {
            crud.UpdateAnimalInDB(animal);
        }

        public void DeleteAnimal(Animal animal)
        {
            crud.DeleteAnimalFromDB(animal);
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
