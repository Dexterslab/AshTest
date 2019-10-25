using System.Collections.Generic;
using Amnicon.Domain;

namespace Amnicon.BusinessLogic
{
    public interface ICalendarService
    {
        List<CalendarEvent> GetEvents();
    }
}