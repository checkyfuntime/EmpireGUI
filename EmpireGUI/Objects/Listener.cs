using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    //comment dev test
    //This might not be being used, remove if possible.
    public partial class listeners
    {
        public class BindIP
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class CertPath
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class DefaultDelay
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public int Value { get; set; }
        }

        public class DefaultJitter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public double Value { get; set; }
        }

        public class DefaultLostLimit
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public int Value { get; set; }
        }

        public class DefaultProfile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Host
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class KillDate
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Launcher
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Name
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Port
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ServerVersion
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class StagingKey
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class WorkingHours
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Options
        {
            public BindIP BindIP { get; set; }
            public CertPath CertPath { get; set; }
            public DefaultDelay DefaultDelay { get; set; }
            public DefaultJitter DefaultJitter { get; set; }
            public DefaultLostLimit DefaultLostLimit { get; set; }
            public DefaultProfile DefaultProfile { get; set; }
            public Host Host { get; set; }
            public KillDate KillDate { get; set; }
            public Launcher Launcher { get; set; }
            public Name Name { get; set; }
            public Port Port { get; set; }
            public ServerVersion ServerVersion { get; set; }
            public StagingKey StagingKey { get; set; }
            public WorkingHours WorkingHours { get; set; }
        }

        public class Listener
        {
            public int ID { get; set; }
            public string listener_category { get; set; }
            public object listener_type { get; set; }
            public string module { get; set; }
            public string name { get; set; }
            public Options options { get; set; }
        }

        public class RootObject
        {
            public List<Listener> listeners { get; set; }
        }

    }
}
