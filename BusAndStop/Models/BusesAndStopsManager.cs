using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAndStop.Models
{
    public static class BusesAndStopsManager
    {
        public static List<string> BusesForStop(string stopName, Stop stop)
        {
            List<string> busesList = new List<string>();
            if(stop.StopsDict.ContainsKey(stopName))
            {
                foreach (var bus in stop.StopsDict[stopName])
                    busesList.Add(bus);
            }
            else
            {
                busesList.Add("no buses");
            }
            return busesList;
        }

        public static List<string> StopsForBus(string busName, Bus bus)
        {
            List<string> stopsList = new List<string>();
            if(bus.BusesDict.ContainsKey(busName))
            {
                foreach (var stop in bus.BusesDict[busName])
                    stopsList.Add(stop);
            }
            else
            {
                stopsList.Add("no stops");
            }
            return stopsList;
        }

        public static List<string> AllBuses(Bus bus)
        {
            string line = "";
            List<string> allBusesList = new List<string>();
            if (allBusesList.Any())
            {
                foreach (var busItem in bus.BusesDict)
                {
                    foreach (var stop in busItem.Value)
                        line = $"{line} {stop}";
                    allBusesList.Add($"Bus {busItem.Key}: {line}");
                    line = "";
                }
            }
            else
            {
                allBusesList.Add("No buses");
            }

            return allBusesList;
        }
    }
}
