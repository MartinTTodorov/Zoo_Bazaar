using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ZooDescriptionManager
    {
        private List<ZooDescription> descriptions = new List<ZooDescription>();
        IZooDescription<ZooDescription> db;
        IAutoIncrementable auto;
        public ZooDescriptionManager(IZooDescription<ZooDescription> db, IAutoIncrementable auto)
        {
            this.db = db;
            this.auto = auto;
            db.GetDescriptions(descriptions);
        }


        public void AddDescription(ZooDescription zd)
        {
            if (descriptions.Find(x => x.Description == zd.Description) is null)
            {
                ZooDescription zdWithId = new ZooDescription(auto.GetNexID(), zd.Description, zd.IsActive, zd.DateOfCreation);
                descriptions.Add(zdWithId);
                db.AddDescription(zdWithId);
                return;
            }
            throw new Exception("There is already such a description!");
        }

        public void DisablePreviousDescription(ZooDescription zd)
        {
            if (descriptions.Find(x => x.Id == zd.Id) is null)
            {
                throw new Exception("There is no such description to delete!");
            }
            db.DisablePreviousDescription(zd);
            int index = descriptions.FindIndex(x => x.Id == zd.Id);
            descriptions[index] = zd;
        }

        public List<ZooDescription> GetDescriptions()
        {
            return descriptions;
        }
    }
}
