using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Models;

namespace WinFormsApp3.Models
{
    public class Tickets
    {
        public int TicketID { get; set; }
        public int EventID { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Availability { get; set; }

        // For database loading
        public Tickets() { }

        // For adding new tickets
        public Tickets(int eventID, string type, decimal price, int availability)
        {
            EventID = eventID;
            Type = type;
            Price = price;
            Availability = availability;
        }
    }
}
//TicketID = _idCounter++;