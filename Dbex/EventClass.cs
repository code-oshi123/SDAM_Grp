using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class EventClass
    {
        private int eventId;
        private string eventName;
        private string eventDescription;
        private string eventDate;
        private string eventLocation;

        public EventClass(int eventId, string eventName, string eventDescription, string eventDate, string eventLocation)
        {
            this.eventId = eventId;
            this.eventName = eventName;
            this.eventDescription = eventDescription;
            this.eventDate = eventDate;
            this.eventLocation = eventLocation;
        }

        public int EventId { get => eventId; set => eventId = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string EventDescription { get => eventDescription; set => eventDescription = value; }
        public string EventDate { get => eventDate; set => eventDate = value; }
        public string EventLocation { get => eventLocation; set => eventLocation = value; }
    }
}
