using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesAndStops.Models
{
    public class StopBus : Bus
    {
        private string _busName;

        public StopBus(Bus bus, string busName)
        {
            this.busesDict = bus.busesDict;
            this.stopsDict = bus.stopsDict;
            _busName = busName;
        }

        public List<string> StopsForBus(string busName)
        {
            List<string> stops = new List<string>();

            if (busesDict.ContainsKey(busName))
            {
                string line = "";

                foreach (var stop in busesDict[busName])
                {
                    string l = "";
                    foreach (var buses in stopsDict[stop])
                    {
                        if (stopsDict[stop].Count == 1 && buses == _busName)
                            l = "no interchange";
                        else if (buses == _busName)
                            continue;
                        else
                            l = $"{l}{buses}";
                    }
                }
            }   
            else
                stops.Add("There is no stops in current bus");
            return stops;
        }
    }
}
