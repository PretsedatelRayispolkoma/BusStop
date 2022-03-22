using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesAndStops.Models
{
    public class Bus
    { 
        public Dictionary<string, HashSet<string>> busesDict;
        public Dictionary<string, HashSet<string>> stopsDict;

        public Bus()
        {
            busesDict = new Dictionary<string, HashSet<string>>();
            stopsDict = new Dictionary<string, HashSet<string>>();
        }

        public void NewBus(string[] command)
        {
            string busName = command[1];
            
            HashSet<string> stopsList = new HashSet<string>();
            
            int stopCount = Convert.ToInt32(command[2]);

            //for (int i = 3; i < stopCount + 3; ++i)
            //{
            //    stopsList.Add(command[i]);
            //    if (stopsDict.ContainsKey(command[i]))
            //        stopsDict[command[i]].Add(busName);
            //    else
            //        stopsDict.TryAdd(command[i], new HashSet<string> { busName });
            //}

            string[] stopsArray = command[3..];

            foreach(var stop in stopsArray)
            {
                stopsList.Add(stop);
                if (stopsDict.ContainsKey(stop))
                    stopsDict[stop].Add(busName);
                else
                    stopsDict.Add(stop, new HashSet<string> { busName });
            }
            busesDict.TryAdd(busName, stopsList);
        }
    }
}
