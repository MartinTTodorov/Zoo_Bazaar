using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IAnimalDB<Animal>
    {
       public List<Animal> GetAnimals();

       public void AddAnimalToDB(Animal animal, Specialization specialization);

       public void UpdateAnimalInDB(Animal animal, int id);


       public void DeleteAnimalFromDB(int id, string reasonForDeparture);
       public bool HasImage(string animalCode);

       public MemoryStream GetMemoryStream(string animalCode);

       public List<string> GetFeeding(Animal animal);

        // Change it pls :P
       public List<string> GetNotes(Animal animal);
       public void AddNote(int id, string note);

    }
}
