using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using WinFormsApp3.Models;

namespace WinFormsApp3.Controller
{
    public class TicketController
    {
        private string connectionString = "server=localhost;user=root;password=;database=ticketdb;";

        public void AddTicket(int eventID, string type, decimal price, int availability)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO tickets (EventID, Type, Price, Availability) VALUES (@eventID, @type, @price, @availability)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventID", eventID);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@availability", availability);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Optional: Show message
                MessageBox.Show("Ticket inserted into the database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting ticket: " + ex.Message);
            }
        }


        public string UpdateTicketPrice(int ticketID, decimal newPrice)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tickets SET Price = @price WHERE TicketID = @ticketID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@price", newPrice);
                    cmd.Parameters.AddWithValue("@ticketID", ticketID);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        Debug.WriteLine($"Ticket ID {ticketID} price updated to {newPrice}");
                        return "Ticket price updated successfully.";
                    }
                    else
                    {
                        Debug.WriteLine($"Ticket with ID {ticketID} not found.");
                        return "Ticket not found.";
                    }
                }
            }
        }

        public bool DeleteTicket(int ticketID)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tickets WHERE TicketID = @ticketID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ticketID", ticketID);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }


        public List<Tickets> GetAllTickets()
        {
            List<Tickets> ticketList = new List<Tickets>();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tickets";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ticketList.Add(new Tickets
                        {
                            TicketID = reader.GetInt32("TicketID"),
                            EventID = reader.GetInt32("EventID"),
                            Type = reader.GetString("Type"),
                            Price = reader.GetDecimal("Price"),
                            Availability = reader.GetInt32("Availability")
                        });
                    }
                }
            }
            return ticketList; // <- return the fresh list
        }


        public string BookTicket(int ticketID, int quantity)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string selectQuery = "SELECT Availability FROM tickets WHERE TicketID = @ticketID";
                using (var selectCmd = new MySqlCommand(selectQuery, conn))
                {
                    selectCmd.Parameters.AddWithValue("@ticketID", ticketID);
                    object result = selectCmd.ExecuteScalar();

                    if (result == null)
                        return "Ticket not found.";

                    int currentAvailability = Convert.ToInt32(result);
                    if (currentAvailability < quantity)
                        return "Not enough tickets available.";

                    string updateQuery = "UPDATE tickets SET Availability = Availability - @quantity WHERE TicketID = @ticketID";
                    using (var updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@quantity", quantity);
                        updateCmd.Parameters.AddWithValue("@ticketID", ticketID);
                        updateCmd.ExecuteNonQuery();
                        return "Ticket(s) booked successfully.";
                    }
                }
            }
        }
    }
}
