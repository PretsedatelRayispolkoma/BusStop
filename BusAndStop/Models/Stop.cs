using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAndStop.Models
{
    public class Stop
    {
        public Dictionary<string, HashSet<string>> StopsDict { get; set; }

        public Stop()
        {
            StopsDict = new Dictionary<string, HashSet<string>>();
        }
    }
}
