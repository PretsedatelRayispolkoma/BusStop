using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesAndStops.Models
{
    public class BusStop : Bus
    {
        private string _stop;

        public BusStop(Bus bus, string stop)
        {
            this.stopsDict = bus.stopsDict;
            _stop = stop;
        }

        public List<string> BusesForStop(string stopName)
        {
            List<string> buses = new List<string>();

            if (stopsDict.ContainsKey(_stop))
                foreach (var bus in stopsDict[stopName])
                    buses.Add(bus);
            else
                buses.Add("No buses in current stop");
            return buses;
        }
    }
}
