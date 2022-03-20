using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStops.Models
{
    internal class StopForBus : Bus
    {
        private string _bus;

        private List<string> _stops = new List<string>();

        internal StopForBus(Bus bus, string nameOfBus)
        {
            this.busesStops = bus.busesStops;
            this.stopOfBuses = bus.stopOfBuses;
            _bus = nameOfBus;
        }

        public List<string> GetStopForBus()
        { 
            if(busesStops.ContainsKey(_bus))
            {
                string s = "";
                foreach(var stops in busesStops[_bus])
                {
                    foreach(var buses in stopOfBuses[stops])
                    {
                        if(stopOfBuses[stops].Count == 1 && buses == _bus)
                        {
                            s = "no interchange";
                        }
                        else if (buses == _bus)
                        {
                            continue;
                        }
                        else
                        {
                            s = $"{s}{buses}";
                        }
                    }
                    s = $"Stop {stops}: {s}";
                    _stops.Add(s);
                }
            }
            else
            {
                _stops.Add("No bus");
            }
            return _stops;
        }
    }
}
