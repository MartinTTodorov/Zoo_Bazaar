using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace LogicLayer
{
    public class CageManager
    {
        private List<Cage> cages;
        private CageDB db = new CageDB();

        public List<Cage> Cages { get { return cages; } }

        public CageManager()
        {
            cages = db.GetCages();
            
        }

        public void GetCages()
        {
            if (cages != null)
            {
                cages.Clear();
            }
            cages = db.GetCages();
        }

        public Cage GetCageByCageNr(int cageNr)
        {
            return cages.Find(x => x.CageNumber == cageNr);
        }

        //public bool AddAnimalInCage(Animal animal, Cage cage)
        //{
        //    if (animal.AnimalType == cage.Type)
        //    {
        //        cages[]
        //    }
        //}
    }
}
