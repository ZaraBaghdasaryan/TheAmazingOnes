using Common.Classes;
using Common.Enum;
using Data.Classes;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Classes
{
    public class ActionPlanProcessor
    {
        private readonly IData _db = new CollectionData();

        public IEnumerable<PointOfAction> GetActionPoints() => _db.GetActionPoints();
        //public IEnumerable<PointOfAction> GetActionPointsByStatus() => _db.GetActionPointsByStatus();

        public IEnumerable<PointOfAction> GetActionPointsByStatus(ActionPointStatuses status = default)
        {
            try
            {
                return _db.GetActionPointsByStatus(status);
            }
            catch
            {
                throw;
            }
            
        }

        public string[] ActionPointTypeStatuses => _db.ActionPointTypeStatuses;
    }
}
