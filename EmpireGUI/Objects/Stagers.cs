using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    class Stagers
    {
        public class Language
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Listener
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class OutFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class SafeChecks
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class UserAgent
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Architecture
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Hijacker
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Interpreter
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Keyboard
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Proxy
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class ProxyCreds
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class StagerRetries
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AppName
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Base64
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class AppIcon
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Delete
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class BinaryFile
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Arch
        {
            public string Description { get; set; }
            public bool Required { get; set; }
            public string Value { get; set; }
        }

        public class Options
        {
            public Language Language { get; set; }
            public Listener Listener { get; set; }
            public OutFile OutFile { get; set; }
            public SafeChecks SafeChecks { get; set; }
            public UserAgent UserAgent { get; set; }
            public Architecture Architecture { get; set; }
            public Hijacker Hijacker { get; set; }
            public Interpreter Interpreter { get; set; }
            public Keyboard Keyboard { get; set; }
            public Proxy Proxy { get; set; }
            public ProxyCreds ProxyCreds { get; set; }
            public StagerRetries StagerRetries { get; set; }
            public AppName AppName { get; set; }
            public Base64 Base64 { get; set; }
            public AppIcon AppIcon { get; set; }
            public Delete Delete { get; set; }
            public BinaryFile BinaryFile { get; set; }
            public Arch Arch { get; set; }
        }

        public class Stager
        {
            public List<string> Author { get; set; }
            public List<string> Comments { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
            public Options options { get; set; }
        }

        public class RootObject
        {
            public List<Stager> stagers { get; set; }
        }
    }
}
