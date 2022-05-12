using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IAnimalDB<Animal>
    {
        List<Animal> GetAnimals();

        void AddAnimalToDB(string animalCode, string name, string gender, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, List<string> feedingTimes, string specialist, int weeklyFeedingIteration);


        void UpdateAnimalInDB(string animalCode, string name, string animalType, string species, int cageNumber, string birthdate, string reasonForArrival, string yearOfArrival, string yearOfDeparture, string reasonForDeparture, string diet, int id);


        void DeleteAnimalFromDB(int id, string reasonForDeparture);
        bool HasImage(string animalCode);

        MemoryStream GetMemoryStream(string animalCode);

        List<string> GetFeeding(Animal animal);
        List<string> GetNotes(Animal animal);
        void AddNote(int id, string note);

    }
}
