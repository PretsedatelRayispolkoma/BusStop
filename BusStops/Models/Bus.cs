using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStops.Models
{
    public class Bus
    {
        public Dictionary<string, HashSet<string>> busesStops;
        public Dictionary<string, HashSet<string>> stopOfBuses;

        public Bus()
        {
            busesStops = new Dictionary<string, HashSet<string>>();
            stopOfBuses = new Dictionary<string, HashSet<string>>();
        }

        public void AddBuss(string[] command)
        {
            HashSet<string> stopsList = new HashSet<string>();
            int countOfStops = Convert.ToInt32(command[2]);
            for(int i = 3; i < countOfStops + 3; ++i)
            {
                stopsList.Add(command[i]);
            }

            if (busesStops.ContainsKey(command[1]) || countOfStops <= 0 || stopsList.Count != countOfStops)
                Console.WriteLine("Incorrect input");
            else
            {
                busesStops.Add(command[1], stopsList);
            }
        }

        public string ShowStops(string stopName)
        {
            string bus = "";
            if (stopOfBuses.ContainsKey(stopName))
            {
                foreach (var i in stopOfBuses[stopName])
                    bus = $"{i}";
                return bus;
            }
            else
                return "no stop";
        }
    }
}
