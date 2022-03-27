using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAndStop.Models
{
    public static class QueryManager
    {
        public static void QueryProcessing(string command)
        {
            string[] commandItems = command.Split();

            Bus bus = new Bus();
            Stop stop = new Stop();

            switch (commandItems[0])
            {
                case "NEW_BUS":
                    bus.AddToDict(commandItems[1], Convert.ToInt32(commandItems[2]), commandItems[3..], stop);
                    break;
                case "BUSES_FOR_STOP":
                    Console.WriteLine(BusesAndStopsManager.BusesForStop(commandItems[1], stop).ToString());
                    break;
                case "STOPS_FOR_BUS":
                    Console.WriteLine(BusesAndStopsManager.StopsForBus(commandItems[1], bus).ToString());
                    break;
                case "ALL_BUSES":
                    Console.WriteLine(BusesAndStopsManager.AllBuses(bus).ToString());
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }

        }
    }
}
