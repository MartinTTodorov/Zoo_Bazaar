using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03.Animal
{
    public class AnimalManager
    {
        List<Animal> animals;

        public AnimalManager()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            if (!animals.Any(a => a.Id == animal.Id))
            {
                animals.Add(animal);
            }
        }

        public void MoveAnimal(int id, int newCage, string newLocation)
        {
            Animal animal = FindAnimal(id);

            if (animal != null)
            {
                animal.CageNumber = newCage;
                animal.Location = newLocation;
            }
        }

        public void RemoveAnimal(int id)
        {
            Animal animal = FindAnimal(id);

            if (animal != null)
            {
                animals.Remove(animal);
            }

        }

        private Animal FindAnimal(int id)
        {
            return animals.Find(a => a.Id == id);
        }
    }
}
