using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Models;
using WinFormsApp3.Controller;
using System.Diagnostics;


namespace WinFormsApp3.Controller
{
    public class TicketController
    {
        private List<Tickets> tickets = new List<Tickets>();



        public void AddTicket(int eventID, string type, decimal price, int availability)
        {
            tickets.Add(new Tickets(eventID, type, price, availability));
        }

        public string UpdateTicketPrice(int ticketID, decimal newPrice)
        {
            var ticket = tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket == null)
            {
                Debug.WriteLine($"Ticket with ID {ticketID} not found.");
                return "Ticket not found.";
            }

            ticket.Price = newPrice;
            Debug.WriteLine($"Ticket ID {ticketID} price updated to {newPrice}");
            return "Ticket price updated successfully.";
        }


        public bool DeleteTicket(int ticketID)
        {
            var ticket = tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket != null)
            {
                tickets.Remove(ticket);
                return true;
            }
            return false;
        }


        public List<Tickets> GetAllTickets()
        {
            return tickets;
        }

        public string BookTicket(int ticketID, int quantity)
        {
            var ticket = tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket != null)
            {
                if (ticket.Availability >= quantity)
                {
                    ticket.Availability -= quantity;
                    return "Ticket(s) booked successfully.";
                }
                else
                {
                    return "Not enough tickets available.";
                }
            }
            return "Ticket not found.";
        }
    }
}
