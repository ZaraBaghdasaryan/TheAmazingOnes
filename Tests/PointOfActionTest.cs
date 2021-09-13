using Common.Classes;
using Data.Classes;
using Data.Interfaces;
using System;
using System.Linq;
using Xunit;

namespace Tests
{
    public class PointOfActionTest
    {
        [Fact]
        public void CanCreatePointOfAction()
        {
            PointOfAction pointOfAction = new PointOfAction(1, "Hej hej", "Q", "Lisa", "BJ", Common.Enum.ActionPointStatuses.Skapad, DateTime.Now);

            Assert.Equal("Hej hej", pointOfAction.Description);
        }

        [Fact]
        public void CanReadPointOfAction()
        {
            IData data = new CollectionData();

            Assert.True(data.GetActionPoints().Count() > 0);
        }
    }
}
