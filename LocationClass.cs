using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbex
{
    internal class LocationClass
    {
        private string locname;
        private string locaddress;
        private string locowner;

        public LocationClass(string locname, string locaddress, string locowner)
        {
            
            this.locname = locname;
            this.locaddress = locaddress;
            this.locowner = locowner;
        }

        
        public string Locname { get => locname; set => locname = value; }
        public string Locaddress { get => locaddress; set => locaddress = value; }
        public string Locowner { get => locowner; set => locowner = value; }
    }
}
