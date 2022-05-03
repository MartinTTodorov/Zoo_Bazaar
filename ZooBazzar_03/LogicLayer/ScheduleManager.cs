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
        EmployeeManagment em = new EmployeeManagment();
        CageManager cm = new CageManager();
        ScheduleDB sdb = new ScheduleDB();
        ContractManager cmngr = new ContractManager();

        List<DailySchedule> dailySchedules = new List<DailySchedule>();


        public List<string> GetCurrentWeek(DateTime pickDate)
        {
            List<string> daysInWeek = new List<string>();

            var now = pickDate;
            var currentDay = now.DayOfWeek;
            int days = (int)currentDay;

            DateTime sunday = now.AddDays(-days);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = sunday.AddDays(i);


                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";

                daysInWeek.Add(date);
            }

            return daysInWeek;
        }



        public void GetWeeklySchedule(DateTime date)
        {
            dailySchedules = sdb.Read(GetCurrentWeek(date));
            cm.GetCageAnimals(dailySchedules);
        }



        public List<Caretaker> GetCaretakers(Cage Cage)
        {
            Cage cage = cm.Cages.Find(x => x.CageNumber == Cage.CageNumber);

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

        public Caretaker AssignedCaretaker(Cage cage, string time)
        {
            if (dailySchedules.Find(x => x.Cage.CageNumber == cage.CageNumber && x.TimeSlot == time) != null)
            {
                return (Caretaker)dailySchedules.Find(x => x.Cage.CageNumber == cage.CageNumber).Employee;
            }
            else
            {
                return null;
            }
        }

        public int Insert(DailySchedule ds)
        {
            dailySchedules.Add(ds);
            return sdb.Add(ds);
        }

        public int Update(DailySchedule ds)
        {
            int index = dailySchedules.FindIndex(x => x.Date == ds.Date && x.Cage.CageNumber == ds.Cage.CageNumber);

            dailySchedules[index] = ds;

            return sdb.EditSpecialist(ds);

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
            List<Cage> allCages = cm.Cages;

            return allCages.FindAll(x => x.CageAnimals.Any(x => x.FeedingTimes.Any(x => x == feedingTime) && x.ReasonForDeparture == null));
        }

        public int GetCagesForShift(Caretaker caretaker)
        {
            if (dailySchedules.FindAll(ds => ds.Employee == caretaker).Count() == 5)
            {
                return 5;
            }
            return 0;
        }

        public List<Caretaker> GetCaretaker(Cage cage)
        {
            List<Caretaker> caretakers = GetCaretakers(cage);

            List<Caretaker> freeCaretakers = new List<Caretaker>();

            foreach (Caretaker caretaker in caretakers)
            {
                cmngr.GetContracts(caretaker);
                
                if ((caretaker.Contracts.Find(c => c.IsValid == true).Fte * 40) >= ((GetCagesForShift(caretaker) * 6) + 6))
                {
                    freeCaretakers.Add(caretaker);
                }
            }
            return freeCaretakers;
        }
    }
}
