using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WinFormsApp3.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsApp3.Controller
{
    public class TicketController

    {
        private readonly string connectionString = "server=localhost;user=root;password=;database=ticketdb;";


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
    try
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
    catch (Exception ex)
    {
        return "Error updating ticket price: " + ex.Message;
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

        private List<Tickets> tickets = new List<Tickets>();

        public List<Tickets> GetAllTickets()
        {
            var ticketList = new List<Tickets>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM tickets";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

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
            return ticketList;
        }


        public List<Tickets> GetTicketsByEventID(int eventID)
        {
            var ticketList = new List<Tickets>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM tickets WHERE EventID = @eventID";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@eventID", eventID);

            using var reader = cmd.ExecuteReader();
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
            return ticketList;
        }
        public bool EventIDExists(int eventID)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tickets WHERE EventID = @eventID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public string UpdateTicketAvailability(int ticketID, int newAvailability)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE tickets SET Availability = @availability WHERE TicketID = @ticketID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@availability", newAvailability);
                        cmd.Parameters.AddWithValue("@ticketID", ticketID);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return "Ticket availability updated successfully.";
                        }
                        else
                        {
                            return "Ticket not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error updating availability: " + ex.Message;
            }
        }


        public List<(string Type, decimal Price)> GetTicketTypesAndPricesByEventID(int eventID)
        {
            var result = new List<(string Type, decimal Price)>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Type, Price FROM tickets WHERE EventID = @eventID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader.GetString("Type");
                            decimal price = reader.GetDecimal("Price");
                            result.Add((type, price));
                        }
                    }
                }
            }

            return result;
        }



        public bool IsValidTicketType(int eventID, string ticketType)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tickets WHERE EventID = @eventID AND Type = @type";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    cmd.Parameters.AddWithValue("@type", ticketType);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        public string BookTicket(int ticketID, int quantity)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Check availability
                        string selectQuery = "SELECT Availability FROM tickets WHERE TicketID = @ticketID";
                        using (var selectCmd = new MySqlCommand(selectQuery, conn, transaction))
                        {
                            selectCmd.Parameters.AddWithValue("@ticketID", ticketID);
                            object result = selectCmd.ExecuteScalar();

                            if (result == null)
                                return "Ticket not found.";

                            int currentAvailability = Convert.ToInt32(result);
                            if (currentAvailability < quantity)
                                return "Not enough tickets available.";

                            // Update availability
                            string updateQuery = "UPDATE tickets SET Availability = Availability - @quantity WHERE TicketID = @ticketID";
                            using (var updateCmd = new MySqlCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@ticketID", ticketID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        // Get price and insert sale
                        string priceQuery = "SELECT Price FROM tickets WHERE TicketID = @ticketID";
                        using (var priceCmd = new MySqlCommand(priceQuery, conn, transaction))
                        {
                            priceCmd.Parameters.AddWithValue("@ticketID", ticketID);
                            object priceResult = priceCmd.ExecuteScalar();
                            if (priceResult == null)
                                throw new Exception("Ticket not found.");

                            decimal price = Convert.ToDecimal(priceResult);
                            decimal totalPrice = price * quantity;

                            string insertQuery = "INSERT INTO sales (TicketID, Quantity, TotalPrice) VALUES (@ticketID, @quantity, @totalPrice)";
                            using (var insertCmd = new MySqlCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@ticketID", ticketID);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        return "Ticket(s) booked successfully.";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return "Booking failed: " + ex.Message;
                    }
                }
            }
        }


        
        public decimal GetTotalRevenue()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(TotalPrice) FROM sales";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
        }
        public decimal? GetTicketPriceByEventAndType(int eventID, string ticketType)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Price FROM tickets WHERE EventID = @eventID AND Type = @type";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    cmd.Parameters.AddWithValue("@type", ticketType);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : (decimal?)null;
                }
            }
        }
        public bool TicketExists(int eventID, string type)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM tickets WHERE EventID = @eventID AND Type = @type";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", eventID);
                    cmd.Parameters.AddWithValue("@type", type);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }






    }
}
