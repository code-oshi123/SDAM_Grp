using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class FeedbackClass
    {
        private static int feedbackid = 0;
        private int eventid;
        private string feedback;
        private string eventname;

        public FeedbackClass(int eventid, string feedback, string eventname)
        {
            this.Eventid = eventid;
            this.Feedback = feedback;
            this.Eventname = eventname;
        }

        public int Eventid { get => eventid; set => eventid = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public string Eventname { get => eventname; set => eventname = value; }
    }
}
