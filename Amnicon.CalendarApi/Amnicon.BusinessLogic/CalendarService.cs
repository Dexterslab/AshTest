using Amnicon.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amnicon.Domain;

namespace Amnicon.BusinessLogic
{
    public class CalendarService : ICalendarService
    {
        private ICalendarRepository _calendarRepo;

        public CalendarService()
        {
            _calendarRepo = new CalendarRepository();
        }

        public List<CalendarEvent> GetEvents()
        {

            // Here we might have business logic to take care too 

            return _calendarRepo.GetEvents();
        }
    }
}
