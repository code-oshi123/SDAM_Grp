using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Models
{
    public class Tickets
  
    {
        private static int _idCounter = 1;

        public int TicketID { get; set; }
        public int EventID { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Availability { get; set; }

        public Tickets(int eventID, string type, decimal price, int availability)
        {
            TicketID = _idCounter++;
            EventID = eventID;
            Type = type;
            Price = price;
            Availability = availability;
        }
    }
}
