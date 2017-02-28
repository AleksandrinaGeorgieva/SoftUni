using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Legion
    {
        public string name { get; set; }
        public long lastActivity { get; set; }
        public Dictionary<string, long> soldiers { get; set; }
    }
}
