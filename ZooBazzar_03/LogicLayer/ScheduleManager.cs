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

        List<DailySchedule> dailySchedules = new List<DailySchedule>();


        public List<string> GetCurrentWeek()
        {
            List<string> daysInWeek = new List<string>();

            var now = DateTime.Now;
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


        public ScheduleManager(string date)
        {
            dailySchedules = sdb.Read(GetCurrentWeek());
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

        public int AssignedCaretaker(int cage, string time)
        {
            if (dailySchedules.Find(x => x.CageNumber == cage && x.TimeSlot == time) != null)
            {
                return dailySchedules.Find(x => x.CageNumber == cage).EmployeeId;
            }
            else
            {
                return 0;
            }
        }

        public int Insert(DailySchedule ds)
        {
            dailySchedules.Add(ds);
            return sdb.Add(ds);
        }

        public int Update(DailySchedule ds)
        {
            int index = dailySchedules.FindIndex(x => x.Date == ds.Date && x.CageNumber == ds.CageNumber);

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

        //public int GetWorkerFTE(int cageNr)
        //{
        //    List<Caretaker> caretakers = GetCaretakers(cageNr);

     

        //    if (caretakers.Any(x => (x.Id * 40) > caretakers.Where(caretaker => caretaker == x).Count))
        //    {

        //    }
        //}
    }
}
