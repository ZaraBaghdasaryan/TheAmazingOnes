using System;
using System.Collections.Generic;
using UI.Data;
using System.Linq;
using System.Threading.Tasks;

namespace UI.IService
{
    public interface IDayEventService
    {
        DayEvent SaveOrUpdate (DayEvent oDayEvent);
        DayEvent GetEvent(DateTime eventDate);
        List<DayEvent> GetEvents(DateTime fromDate, DateTime toDate);
        string Delete(int id);
    }
}
  