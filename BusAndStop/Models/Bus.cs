using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAndStop.Models
{
    public class Bus
    {
        public Dictionary<string, HashSet<string>> BusesDict { get; set; }

        public Bus()
        {
            BusesDict = new Dictionary<string, HashSet<string>>();
        }

        public void AddToDict(string nameOfBus, int countOfStops, string[] stops, Stop stop)
        {
            if(countOfStops != stops.Length || countOfStops <= 0 || stops.Contains(nameOfBus))
            {
                throw new Exception("Incorrect data, try again");
            }
            else
            {
                HashSet<string> stopsList = new HashSet<string>();

                foreach(var stopItem in stops)
                {
                    stopsList.Add(stopItem);
                    if(stop.StopsDict.ContainsKey(stopItem))
                    {
                        stop.StopsDict[stopItem].Add(nameOfBus);
                    }
                    else
                    {
                        stop.StopsDict.Add(stopItem, new HashSet<string> { nameOfBus });
                    }                   
                }
                BusesDict.Add(nameOfBus, stopsList);
            }
        }
    }
}
