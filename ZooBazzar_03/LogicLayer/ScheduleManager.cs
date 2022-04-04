using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<<< HEAD:ZooBazzar_03/LL/ScheduleManager.cs
using Modules;
using DAL;

namespace LL
========
using DataAccessLayer;
using Entities;



namespace LogicLayer
>>>>>>>> 1a8f676ad8d75ef9e26ffa274de82d0a6e9ab07d:ZooBazzar_03/LogicLayer/ScheduleManager.cs
{
    public class ScheduleManager
    {
        
        public void GetDate(int index, Panel calendar)
        {
            calendar.Controls.Clear();

            for (int i = 0; i < 7; i++)
            {
                DateTime day = DateTime.Now;

                day = day.AddDays(i + index);
               // Date uc = new Date();

                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";
                string weekday = day.DayOfWeek.ToString();
               // uc.GetDate(weekday, date);

                //calendar.Controls.Add(uc);

            }
        }
    }
}
