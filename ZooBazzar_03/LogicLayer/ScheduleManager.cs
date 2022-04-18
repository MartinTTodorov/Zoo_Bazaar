using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace LogicLayer
{
    public class ScheduleManager
    {
        AnimalManager am = new AnimalManager();
        EmployeeManagment em = new EmployeeManagment();
        CageManager cm = new CageManager();
        ScheduleDB sdb = new ScheduleDB();
        CageDB cdbm = new CageDB();

        public bool EmptyCage(int cageNumber)
        {
            if (cm.Cages.Find(x => x.CageNumber == cageNumber) != null)
            {
                if (cm.Cages.Find(x => x.CageNumber == cageNumber).CageAnimals.Count > 0)
                {

                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Caretaker> GetCaretakers(int cageNumber)
        {
            Cage cage = cm.Cages.Find(x => x.CageNumber == cageNumber);

            switch (cage.Type)
            {
                case AnimalType.Mammal:
                    return em.CaretakersBySpecialization(Specialization.Mammalogist);
                    break;
                case AnimalType.Bird:
                    return em.CaretakersBySpecialization(Specialization.Ornithologist);
                    break;
                case AnimalType.Fish:
                    return em.CaretakersBySpecialization(Specialization.Ichthyologist);
                    break;
                case AnimalType.Insect:
                    return em.CaretakersBySpecialization(Specialization.Entomologist);
                    break;
                case AnimalType.Reptile:
                    return em.CaretakersBySpecialization(Specialization.Herprtologist);
                    break;
                case AnimalType.Amphibian:
                    return em.CaretakersBySpecialization(Specialization.Herprtologist);
                    break;
                default: throw new ArgumentException("IDk");

            }
        }

        public int AssignedCaretaker(string date, int cage)
        {
            if (sdb.GetSchedules(date).Find(x => x.CageNumber == cage) != null)
            {
                return sdb.GetSchedules(date).Find(x => x.CageNumber == cage).EmployeeId;
            }
            else
            {
                return 0;
            }
        }


        public bool CheckDate(DateTime date)
        {
            if (date.CompareTo(DateTime.Today) > -1)
            {
                return true;
            }
            return false;
        }

        public List<Cage> GetCages(string feedingTime)
        {
            List<Cage> allCages = cdbm.GetCages();

            return allCages.FindAll(x => x.CageAnimals.Any(x => x.FeedingTimes.Any(x => x == feedingTime)));
        }


    }
}
