using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesAndStops.Models
{
    public static class Query
    {
        public static void ProcessQuery(string command)
        {
            string[] commandItems = command.Split();

            Bus bus = new Bus();

            switch (commandItems[0])
            {
                case "NEW_BUS":
                    bus.NewBus(commandItems);
                    break ;
                case "BUSES_FOR_STOP":
                    BusStop busStop = new BusStop(bus, commandItems[1]);
                    PrintList(busStop.BusesForStop(commandItems[1]));
                    break;
                case "STOPS_FOR_BUS":
                    StopBus stopBus = new StopBus();
                    PrintList(stopBus.StopsForBus(commandItems[1])); 
                    break;
                case "ALL_BUSES":
                    AllBuses allBuses = new AllBuses();
                    PrintList(allBuses.GetAllBuses(bus));
                    break;
                default:
                     Console.WriteLine("Unknown command");
                    break;
            }
        }

        private static void PrintList(List<string> list)
        {
            foreach (var item in list)
                Console.Write(item.ToString());
        }
    }
}
