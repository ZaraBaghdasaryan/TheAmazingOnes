using System;
using System.Collections.Generic;
using Common.Classes;

namespace Common.Interfaces
{
    public interface IDayEventService
    {
        DayEvent SaveOrUpdate (DayEvent oDayEvent);
        DayEvent GetEvent(DateTime eventDate);
        List<DayEvent> GetEvents(DateTime fromDate, DateTime toDate);
        string Delete(int id);
    }
}
  