using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    public partial class BaseAgent
    {
        /**
        public string ListenerName { get; set; }
        public string IPAddress { get; set; }
        public string AgentName { get; set; }
        public string OperatingSystem { get; set; }
        public string ProcessID { get; set; }
        public string ProcessName { get; set; }
        public string LastCheckin { get; set; }
        public string UserContext { get; set; }
        public List<string> ConsoleOutput = new List<string>();
      /**  public BaseAgent(string listener, string IP, string agent, string OS, string procID, string procName, string lastcheck, string user) {
            ListenerName = listener;
            IPAddress = IP;
            AgentName = agent;
            OperatingSystem = OS;
            ProcessID = procID;
            ProcessName = procName;
            LastCheckin = lastcheck;
            UserContext = user;
            ConsoleOutput = new List<string>();


        }
    **/
        string ID { get; set; }
        string CheckinTime { get; set; }
        string Children { get; set; }
        int Delay { get; set; }
        string ExternalIP { get; set; }
        string Functions { get; set; }
        string Headers { get; set; }
        int HighIntegrity { get; set; }
        string HostName { get; set; }
        string InternalIP { get; set; }
        string Jitter { get; set; }
        string KillDate { get; set; }
        string LastSeenTime { get; set; }
        string Listener { get; set; }
        string LostLimit { get; set; }
        string Name { get; set; }
        string OldURIs { get; set; }
        string OSDetails { get; set; }
        string Parent { get; set; }
        string ProcessID { get; set; }
        string ProcessName { get; set; }
        string PSVersion { get; set; }
        string Results { get; set; }
        string Servers { get; set; }
        string SessionID { get; set; }
        string SessionKey { get; set; }
        string Taskings { get; set; }
        string URIs { get; set; }
        string UserAgent { get; set; }
        string UserName { get; set; }
        string WorkingHours { get; set; }

    }
}
