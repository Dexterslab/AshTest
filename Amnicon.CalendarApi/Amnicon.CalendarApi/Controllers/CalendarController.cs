using System;
using System.Net;
using System.Web.Http;
using Amnicon.BusinessLogic;

namespace Amnicon.CalendarApi.Controllers
{
    public class CalendarController : ApiController
    {
        // This is poor man's constructor dependency Injection. I would rather use some IoC Ninject or Autofac that gives more power like scopes etc

        private ICalendarService _calendarService;

        public CalendarController()
        {
            _calendarService = new CalendarService();
        }


        // Might need to secure the API using some JWT tokens etc
        [HttpPost, Route("v1/Calendar/Events")]
        public IHttpActionResult GetEvents()
        {
            // here we can avoid try catch if extension points of MVC are used,
            // the code in the base controller will take care of try catch blocks and not needed in all over the code base. just need it gloabally. 

            try
            {
                var result = _calendarService.GetEvents();
                return Content(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                // Log the exception if using something like log4Net/serilog  etc
                throw;
            }
        }


        // more methods can be added like 
        // GetEventById(int id)
        // DeleteEvent(int Id)
        // UpdateEvent(int Id)

    }
}
