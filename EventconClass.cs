
﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class EventconClass
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=test";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddEvent(string id ,string organizerid,string eventName, string eventDescription, DateTime eventDate, string mor_ev, string eventLocation)
        {
            EventClass eventClass = new EventClass(id,organizerid,eventName,eventDescription,eventDate,mor_ev,eventLocation);

            if(id.Equals("") || organizerid.Equals("") || eventName.Equals("") || eventDescription.Equals("") || eventDate.Equals("") || mor_ev.Equals("") || eventLocation.Equals(""))
            {
                return "Please fill all fields";
            }

            try
            {
                Convert.ToInt32(id);
                Convert.ToInt32(organizerid);

            }
            catch (Exception ex)
            {
                return "Id must be a number.";
            }

            //return "ok";
            string query = "INSERT INTO eventtable (id, organizerid, eventname, eventdescription, eventdate, eventloc) VALUES (@id, @eventname, @eventdescription, @eventdate, @eventloc)";
            //return "added";

            string query1 = "Select eventname,Eventdate,eventloc from eventtable WHERE id = @id";
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.Read())
                {
                    string dbename = reader.GetString("eventname");
                    string dbdate = reader.GetString("eventdate");
                    string dbloc = reader.GetString("eventloc");
                    conn.Close();

                    if (dbename.Equals(eventName))
                    {
                        //return "Event already exists/matched";
                        DateTime newdate = eventDate;
                        string newloc = eventLocation;
                        string newdes = eventDescription;
                        conn.Open();
                        string query2 = "UPDATE eventtable SET eventdate = @newdate, eventloc = @newloc, eventdes = @newdes WHERE id = @id";
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@newdes", newdes);
                        cmd2.Parameters.AddWithValue("@newdate", newdate);
                        cmd2.Parameters.AddWithValue("@newloc", newloc);
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        return "Event already exists, updated the event";
                    }
                    else
                    {
                        return "Event id and name doesn't match";
                    }
                }
                conn.Close();
                conn.Open();
                string query3 = "INSERT INTO eventtable (id, eventname,eventdate,eventloc,eventdes) VALUES (@id, @eventName, @eventDate, @eventLocation, @eventDescription)";
                MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                cmd3.Parameters.AddWithValue("@id", id);
                cmd3.Parameters.AddWithValue("@eventName", eventName);
                cmd3.Parameters.AddWithValue("@eventDate", eventDate);
                cmd3.Parameters.AddWithValue("@eventLocation", eventLocation);
                cmd3.Parameters.AddWithValue("@eventDescription", eventDescription);
                cmd3.ExecuteNonQuery();
                conn.Close();
                return "Event added successfully";
            }

        }

        public static string DeleteItem(string id, string eventname)
        {
            if (id.Equals("") || eventname.Equals(""))
            {
                return "Please fill all fields";
            }
            try
            {
                Convert.ToInt32(id);
            }
            catch (Exception ex)
            {
                return "Id must be a number.";
            }
            //string query = "DELETE FROM eventtable WHERE id = @id AND eventname = @eventname";
            string query = "SELECT eventname FROM eventtable WHERE id = @id";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@eventname", eventname);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string dbename = reader.GetString("eventname");
                    conn.Close();
                    if (dbename.Equals(eventname))
                    {
                        conn.Open();
                        string query1 = "DELETE FROM eventtable WHERE id = @id AND eventname = @eventname";
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.Parameters.AddWithValue("@eventname", eventname);
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                        return "Event deleted successfully";
                    }
                    else
                    {
                        return "Event id and name doesn't match";
                    }
                }
                conn.Close();
                return "Event not found";
            }

        }

        public static List<string> ViewEvents()
        {
            List<string> items = new List<string>();
            string query = "SELECT * FROM eventtable";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string eventname = reader.GetString("eventname");
                            string eventdate = reader.GetString("Eventdate");
                            string eventloc = reader.GetString("eventloc");
                            string eventdes = reader.GetString("eventdes");
                            items.Add($"{id} | {eventname} | {eventdate} | {eventloc} | {eventdes}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log error or show message
                    Debug.WriteLine($"Database error: {ex.Message}");
                    return null;
                }
            }

            return items;
        }
    }
}
