using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStops.Models
{
    internal class BusesForStop : Bus
    {
        private string _stop;

        private List<string> buses = new List<string>();

        internal BusesForStop(string stop)
        {
            _stop = stop;
        }

        public List<string> GetBusesForStop(string stop)
        {
            if(stopOfBuses.ContainsKey(_stop))
            {
                foreach (var item in stopOfBuses[_stop])
                    buses.Add(item);
            }
            else
            {
                buses.Add("no stops");
            }
            return buses;
        }
    }
}
