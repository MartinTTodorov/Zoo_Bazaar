using Entities;

namespace DataAccessLayer 
{
    public class ScheduleDBMock : IScheduleDB<DailySchedule>
    {
        public bool Add(DailySchedule ds)
        {
            return true;
        }


        public List<DailySchedule> Read(List<string> days)
        {
            return new List<DailySchedule>();
        }

        public bool Update(DailySchedule ds)
        {
            return true;
        }
    }
}
