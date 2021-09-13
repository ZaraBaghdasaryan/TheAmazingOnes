using Common.Classes;
using Common.Enum;
using Common.Interfaces;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Classes
{
    //Motsvarar databasen
    public class CollectionData : IData
    {
        readonly List<PointOfAction> _actionPoints = new List<PointOfAction>();
        //readonly List<IAddPointOfAction> _addedActionPoints = new List<IAddPointOfAction>();

        #region Property för att hämta nästa id som normalt hämtas av databasen.
        public int NextActionPointId => _actionPoints.Count.Equals(0) ? 1 : _actionPoints.Max(a => a.Id) + 1;
        #endregion

        public CollectionData()
        {
            SeedData();
        }

        private void SeedData()
        {
            //Lägger till nya handlingspunkter
            _actionPoints.Add(new PointOfAction(1, "TM, ansatsskruv saknas", "M", "Frida", "Dogger Bank", Common.Enum.ActionPointStatuses.Skapad, DateTime.Now));
            _actionPoints.Add(new PointOfAction(2, "Grindmaterial HV", "M", "Frida", "BJ", Common.Enum.ActionPointStatuses.Behandlas, DateTime.Now));

            //Add status to actionpoint
            var actionpoint1 = _actionPoints.Single(a => a.Id.Equals(1));
            actionpoint1.Status = ActionPointStatuses.Eskalerad;
        }

        public IEnumerable<PointOfAction> GetActionPoints() => _actionPoints;

        //Kan hämta ut baserat på vilken status den har ()
        public IEnumerable<PointOfAction> GetActionPointsByStatus(ActionPointStatuses status = default)
        {
            if (status == default) return _actionPoints;
            return _actionPoints.Where(a => a.Status.Equals(status));
        }
        
    }
}
