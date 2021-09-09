using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using Business.Classes;

namespace Tests
{
    public class ActionPlanProcessorTests
    {
        [Fact]
        public void CanReadPointOfActions()
        {
            var app = new ActionPlanProcessor();
            Assert.True(app.GetActionPoints().Count() > 0);
        }
    }

}
