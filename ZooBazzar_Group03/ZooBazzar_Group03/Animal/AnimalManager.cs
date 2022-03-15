using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
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

        public void MoveAnimal(string id, int newCage)
        {
            Animal animal = FindAnimal(id);

            if (animal != null)
            {
                animal.CageNumber = newCage;
            }
        }

        public void RemoveAnimal(string id)
        {
            Animal animal = FindAnimal(id);


            if (animal != null)
            {
                animals.Remove(animal);
            }

        }

        private Animal FindAnimal(string id)
        {
            return animals.Find(a => a.Id == id);
        }


    }
}
