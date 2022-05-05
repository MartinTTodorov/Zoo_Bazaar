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

        int fullShiftHours = 6;
        int halfShiftHours = 3;

        public List<string> GetWeek(DateTime pickDate, int index)
        {
            List<string> daysInWeek = new List<string>();

            var now = pickDate;
            var currentDay = now.DayOfWeek;
            int days = (int)currentDay;

            DateTime sunday = now.AddDays(-days);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = sunday.AddDays(i + index);


                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";

                daysInWeek.Add(date);
            }

            return daysInWeek;
        }



        public void GetWeeklySchedule(DateTime date)
        {
            dailySchedules = sdb.Read(GetWeek(date, 0));
            //cm.GetCageAnimals(dailySchedules);
        }



        public List<Caretaker> GetCaretakers(AnimalType type)
        {
            switch (type)
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

        public DailySchedule AssignedCaretaker(string time, string date, AnimalType type)
        {
            DailySchedule ds = dailySchedules.Find(ds => ds.TimeSlot == time && ds.Date == date && ds.Type == type);

            if (ds != null)
            {
                return ds;
            }

            return null;
        }

        public bool Insert(DailySchedule ds)
        {
            if (sdb.Add(ds))
            {
                dailySchedules.Add(ds);
                return true;
            }
            return false;
        }

        public bool Update(DailySchedule ds)
        {
            if (sdb.EditSpecialist(ds))
            {
                int index = dailySchedules.FindIndex(x => x.Date == ds.Date && x.Type == ds.Type && x.TimeSlot == x.TimeSlot);

                dailySchedules[index] = ds;

                return true;
            }

            return false;

        }

        public bool CheckDate(DateTime date)
        {
            if (date.CompareTo(DateTime.Today) > -1)
            {
                return true;
            }
            return false;
        }

        public List<Cage> GetCages(string feedingTime, AnimalType type)
        {
            List<Cage> allCages = cm.Cages;

            return allCages.FindAll(x => x.CageAnimals.Any(x => x.FeedingTimes.Any(x => x == feedingTime) && x.ReasonForDeparture == null) && x.CageAnimals.All(animal => animal.AnimalType == type));
        }

        public int GetWorkedHours(Caretaker caretaker)
        {
            int fullShifts = dailySchedules.FindAll(ds => ds.MainCaretakerFir.Id == caretaker.Id || ds.MainCaretakerSec.Id == caretaker.Id).Count * fullShiftHours;

            int halfShift = dailySchedules.FindAll(ds => ds.HelpCaretaker != null).FindAll(ds => ds.HelpCaretaker.Id == caretaker.Id).Count * halfShiftHours;

            return fullShifts + halfShift;
        }

        public List<Caretaker> GetFullShiftCaretaker(AnimalType type, string date, string timeSlot)
        {
            List<Caretaker> caretakers = GetCaretakers(type);

            List<Caretaker> freeCaretakers = new List<Caretaker>();

            foreach (Caretaker caretaker in caretakers)
            {
                cmngr.GetContracts(caretaker);
                
                if ((caretaker.Contracts.Find(c => c.IsValid == true).Fte * 40) >= (GetWorkedHours(caretaker) + fullShiftHours))
                {
                    freeCaretakers.Add(caretaker);
                }
            }

            DailySchedule ds = AssignedCaretaker(timeSlot, date, type);

            if (ds != null)
            {
                if (!freeCaretakers.Any(x => x.Id == ds.MainCaretakerFir.Id))
                {
                    freeCaretakers.Add(ds.MainCaretakerFir);
                }
                if (!freeCaretakers.Any(x => x.Id == ds.MainCaretakerSec.Id))
                {
                    freeCaretakers.Add(ds.MainCaretakerSec);
                }
            }

            return freeCaretakers;
        }

        public List<Caretaker> GetHalfShiftCaretaker(AnimalType type, string date, string timeSlot)
        {
            List<Caretaker> caretakers = GetCaretakers(type);

            List<Caretaker> freeCaretakers = new List<Caretaker>();

            foreach (Caretaker caretaker in caretakers)
            {
                cmngr.GetContracts(caretaker);

                if ((caretaker.Contracts.Find(c => c.IsValid == true).Fte * 40) >= (GetWorkedHours(caretaker) + halfShiftHours))
                {
                    freeCaretakers.Add(caretaker);
                }
            }

            DailySchedule ds = AssignedCaretaker(timeSlot, date, type);

            if (ds != null)
            {
                
                if (ds.HelpCaretaker != null)
                {
                    if (!freeCaretakers.Any(x => x.Id == ds.HelpCaretaker.Id))
                    {
                        freeCaretakers.Add(ds.HelpCaretaker);
                    }
                }
            }

            return freeCaretakers;
        }
    }
}
