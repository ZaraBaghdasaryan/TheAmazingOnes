using Common.Classes;
using Common.Enum;
using Common.Interfaces;
using Data.Classes;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests
{
    public class CommonTests
    {
        [Fact]
        public void CanCreatePointOfAction()
        {
            IPointOfAction pointOfAction = new PointOfAction(3, "TM, ansatsskruv saknas", "M", "Lisa", "Projekt 13", Common.Enum.ActionPointStatuses.Skapad, DateTime.Now);
            IAddPointOfAction addactionpoint = new AddPointOfAction(3, "Hejsan hoppsan", "Q", "Project X");

            Assert.Equal(3, addactionpoint.Id);
        }

        [Fact]
        public void CanGetActionPints()
        {
            IData data = new CollectionData();

            Assert.True(data.GetActionPoints().Count() > 0);
        }

        [Fact]
        public void CanGetActionPintsByStatus()
        {
            IData data = new CollectionData();

            Assert.True(data.GetActionPointsByStatus(ActionPointStatuses.Behandlas).Count() > 0);
        }
    }
}
