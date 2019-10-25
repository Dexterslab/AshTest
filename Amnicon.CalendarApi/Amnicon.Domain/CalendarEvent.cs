using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amnicon.Domain
{
    public class CalendarEvent
    {

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }  // when was event created
        public DateTime UpdatedDate { get; set; } // when was event updated
        public string Title { get; set; }
        public string Description { get; set; } 
        public EventCreator Creator { get; set; } //creator/owner of the event

        public string  Location { get; set; } // might like to add the address of the place to go, like interviewer address on the day of interview event
        public DateTime StartDateTime { get; set; } 
        public DateTime EndDateTime { get; set; }

        public string TimeZone { get; set; } //might need to know the timezone of the user (adds more complexity but if in case that has to be considered
        
    }
}
