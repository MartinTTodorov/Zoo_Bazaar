using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;
using DAL;

namespace LL
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
                Date uc = new Date();

                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";
                string weekday = day.DayOfWeek.ToString();
                uc.GetDate(weekday, date);

                calendar.Controls.Add(uc);

            }
        }
    }
}
