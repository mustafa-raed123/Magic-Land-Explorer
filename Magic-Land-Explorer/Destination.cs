using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{
    public class Destination
    {
        public string name { get; set; }
        public string type { get; set; }
        public string location { get; set; }
        public string? duration { get; set; }
        public string description { get; set; } 
        public string? show_time { get; set; } = null!;
    }
}
