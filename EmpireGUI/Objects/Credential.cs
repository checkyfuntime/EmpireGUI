using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    public class Credential
    {
        public class Cred
        {
            public int ID { get; set; }
            public string credtype { get; set; }
            public string domain { get; set; }
            public string host { get; set; }
            public string notes { get; set; }
            public string os { get; set; }
            public string password { get; set; }
            public string sid { get; set; }
            public string username { get; set; }
        }

        public class RootObject
        {
            public List<Cred> creds { get; set; }
        }
    }
}
