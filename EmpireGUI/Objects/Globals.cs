using System;
using EmpireGUI.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    public static class Globals
    {
        public static string apitoken { get; set; }
        public static string serverIP { get; set; }
        public static string serverPort { get; set; }
        public static listeners.RootObject activelisteners { get; set; }
        public static Modules.RootObject modulesList { get; set; }

        public static Credential.RootObject credsList { get; set; }

        public static List<string> drawnObjects = new List<string>();
        public static List<string> drawnStagerObjects = new List<string>();
        public static List<string> drawnModuleObjects = new List<string>();
        public static List<string> drawnListenerObjects = new List<string>();

        public static string modulesJSON { get; set; }
        public static string agentsJSON { get; set; }
        public static string listenersJSON { get; set; }
        public static string stagersJSON { get; set; }
        public static int pollingValue { get; set; }

        public static string credsJSON { get; set; }

        public static List<string> Stagers = new List<string>();
        public static List<string> Agents = new List<string>();
    }
}
