using BusesAndStops.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BusesAndStopsTest
{
    [TestClass]
    public class FindingStopsTest
    {
        [TestMethod]
        public void StopsForBusTest()
        {
            Bus bus = new Bus();

            string command = "NEW_BUS 32K 6 Tolstopaltsevo Marushkino Vnukovo Peredelkino Solntsevo Skolkovo";

            string[] commandItems = command.Split();

            bus.NewBus(commandItems);

            BusStop busStop = new BusStop(bus, commandItems[5]);

            busStop.BusesForStop(commandItems[5]);
        }
    }
}
