using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amnicon.Domain;

namespace Amnicon.DataAccess
{
    public class CalendarRepository : ICalendarRepository
    {

        // We might be referencing Entity framework here or Dapper depending on Technology choice. 

        public List<CalendarEvent> GetEvents()
        {

            // Get data from DB and then map it to the business DTO might use AutoMapper too

            return null;//
        }

    }
}
