
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class EventClass
    {
        private string eventId;
        private string organizerid;
        private string eventName;
        private string eventDescription;
        private DateTime eventDate;
        private string eventLocation;
        private string mor_ev;

        public EventClass(string eventId, string organizerid, string eventName, string eventDescription, DateTime eventDate, string eventLocation, string mor_ev)
        {
            this.eventId = eventId;
            this.organizerid = organizerid;
            this.eventName = eventName;
            this.eventDescription = eventDescription;
            this.eventDate = eventDate;
            this.eventLocation = eventLocation;
            this.mor_ev = mor_ev;
        }

        public string EventId { get => eventId; set => eventId = value; }
        public string Organizerid { get => organizerid; set => organizerid = value; }
        public string EventName { get => eventName; set => eventName = value; }
        public string EventDescription { get => eventDescription; set => eventDescription = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }
        public string EventLocation { get => eventLocation; set => eventLocation = value; }
        public string Mor_ev { get => mor_ev; set => mor_ev = value; }
    }
}
