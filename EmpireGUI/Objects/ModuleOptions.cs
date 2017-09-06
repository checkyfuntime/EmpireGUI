using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    public class ModuleOptions
    {
        public class Options
        {
            public string optionValue { get; set; }
            public string optionDescription { get; set; }
            public string optionRequired { get; set; }
            public Options(string Description, string Value, string Required)
            {
                optionValue = Value;
                optionDescription = Description;
                optionRequired = Required;

            }
        }

    }
}
