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
    //shopitem item = new shopitem(Convert.ToInt32(id), name, Convert.ToInt32(qun));
    internal class ReviewConClass
    {
        static string connectionString = "server=localhost;uid=root;pwd=;database=test";
        static MySqlConnection conn = new MySqlConnection(connectionString);

        public static string AddReview(string eventreviewid, string eventreviewname, string eventreview)
        {

            FeedbackClass feedback = new FeedbackClass(Convert.ToInt32(eventreviewid), eventreviewname,eventreview);
            

            if (eventreviewid.Equals("") || eventreviewname.Equals("") || eventreview.Equals(""))
            {
                return "Please fill all fields";
            }
            try
            {
                Convert.ToInt32(feedback.Eventid);
            }
            catch (Exception ex)
            {
                return "Id must be a number.";
            }
          
            conn.Open();
            string query4 = "INSERT INTO feedbacktable (eventid, eventname, feedback) VALUES (@feedback.Eventid, @feedback.Feedback, @feedback.Eventname)";
            MySqlCommand cmd4 = new MySqlCommand(query4, conn);
            cmd4.Parameters.AddWithValue("@feedback.Eventid", feedback.Eventid);
            cmd4.Parameters.AddWithValue("@feedback.Feedback", feedback.Feedback);
            cmd4.Parameters.AddWithValue("@feedback.Eventname", feedback.Eventname);
            cmd4.ExecuteNonQuery();
            conn.Close();
            return "Feedback Added Sucsessfully";
        }
        
        public static List<string> Viewfeedback()
        {
            List<string> items = new List<string>();
            string query = "SELECT * FROM feedbacktable";

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
                            int index = reader.GetInt32("id");
                            string eventid = reader.GetString("eventid");
                            string eventname = reader.GetString("eventname");
                            string eventfeedback = reader.GetString("feedback");
                            items.Add($"{index} | {eventid} | {eventname} | {eventfeedback} |");
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
