using System.Collections.Generic;
using Amnicon.Domain;

namespace Amnicon.DataAccess
{
    public interface ICalendarRepository
    {
        List<CalendarEvent> GetEvents();
    }
}