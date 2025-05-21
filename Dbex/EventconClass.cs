using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class EventconClass
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=testdatabase";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddEvent(string id ,string eventName, string eventDescription, DateTime eventDate, string eventLocation)
        {
            if(id.Equals("") || eventName.Equals("") || eventDescription.Equals("") || eventDate.Equals("") || eventLocation.Equals(""))
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

            //return "ok";
            string query = "INSERT INTO eventtable (id, eventname, eventdescription, eventdate, eventloc) VALUES (@id, @eventname, @eventdescription, @eventdate, @eventloc)";
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
    }
}
