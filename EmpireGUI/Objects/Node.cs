using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireGUI.Objects
{
    class Node
    {
        private readonly IDictionary<string, Node> _nodes =
            new Dictionary<string, Node>();

        public string Path { get; set; }
    }
}
