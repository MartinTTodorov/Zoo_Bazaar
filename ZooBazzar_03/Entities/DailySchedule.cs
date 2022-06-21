using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DailySchedule
    {
        private int id;
        private string date;
        private Caretaker mainCaretakerFir;
        private Caretaker mainCaretakerSec;
        private Caretaker helpCaretaker;
        private string timeSlot;
        private AnimalType type;

        public int Id { get { return id; } }
        public string Date { get { return date; } }
        public string TimeSlot { get { return timeSlot; } }
        public Caretaker MainCaretakerFir { get { return mainCaretakerFir; } }
        public Caretaker MainCaretakerSec { get { return mainCaretakerSec; } }
        public Caretaker HelpCaretaker { get { return helpCaretaker; } }
        public AnimalType Type { get { return type; } }


        public DailySchedule(int id, AnimalType type, string date, Caretaker mainFirst, Caretaker mainSecond, Caretaker helpCaretaker, string timeSlot)
        {
            this.id = id;
            this.type = type;
            this.date = date;
            this.mainCaretakerFir = mainFirst;
            this.mainCaretakerSec = mainSecond;
            this.helpCaretaker = helpCaretaker;
            this.timeSlot = timeSlot;
        }


        //Not id save a cage
        //Not relly on the gui to check if the caretaker is specialized
        //List of animals in the cage class   --- methods - getCurrentSpecies or smth like that


    }
}
