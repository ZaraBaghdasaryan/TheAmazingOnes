using Common.Classes;
using Common.Enum;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IData
    {
        IEnumerable<PointOfAction> GetActionPoints();

        //IEnumerable<IAddPointOfAction> GetAddedPointsOfAction(ActionPointStatuses status = default);

        IEnumerable<PointOfAction> GetActionPointsByStatus(ActionPointStatuses status = default);

        //Default interface method
        public string[] ActionPointTypeStatuses => Enum.GetNames(typeof(ActionPointStatuses));
    }
}
