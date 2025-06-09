using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class AdminConClass
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=test";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddLoc(string name,string address,string ownername)
        {
            LocationClass location = new LocationClass(name, address, ownername);

            if (name.Equals("") || address.Equals("") || ownername.Equals(""))
            {
                return "Please fill all fields";
            }
            
            
            conn.Open();
            string query5 = "INSERT INTO locationtable (locname, locaddress, locowner) VALUES (@location.Locname, @location.Locaddress, @location.Locowner)";
            MySqlCommand cmd4 = new MySqlCommand(query5, conn);
            cmd4.Parameters.AddWithValue("@location.Locname", location.Locname);
            cmd4.Parameters.AddWithValue("@location.Locaddress", location.Locaddress);
            cmd4.Parameters.AddWithValue("@location.Locowner", location.Locowner);
            cmd4.ExecuteNonQuery();
            conn.Close();
            return "Location Added";
        }

        public static List<string> ViewAdminEvents()
        {
            List<string> events = new List<string>();
            string query = "SELECT * FROM locationtable";


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
                            int locid = reader.GetInt32("locid");
                            string locname = reader.GetString("locname");
                            string locaddress = reader.GetString("locaddress");
                            string locowner = reader.GetString("locowner");
                            string avalilability = reader.GetString("Avalilability");


                            events.Add($"{locid} | {locname} | {locaddress} | {locowner} | {avalilability}");

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

            return events;
        }
    }
}
