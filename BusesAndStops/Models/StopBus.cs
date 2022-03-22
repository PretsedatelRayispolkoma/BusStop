using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesAndStops.Models
{
    public class StopBus : Bus
    {
        public List<string> StopsForBus(string busName)
        {
            List<string> stops = new List<string>();

            if (busesDict.ContainsKey(busName))
                foreach (var stop in busesDict[busName])
                    stops.Add(stop);
            else
                stops.Add("There is no stops in current bus");
            return stops;
        }
    }
}
