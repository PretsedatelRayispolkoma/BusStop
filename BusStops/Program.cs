using BusStops.Models;
using System;

namespace BusStops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            int q = Convert.ToInt32(Console.ReadLine());

            string[] commands = new string[q];

            for(int i = 0; i < q; ++i)
            {
                commands[i] = Console.ReadLine();
            }

            for(int i = 0; i < q; ++i)
            {
                string[] commandItems = commands[i].Split(' ');

                switch (commandItems[0])
                {
                    case "NEW_BUS":
                        bus.AddBuss(commandItems);
                        break;
                }

            }
            
        }
    }
}
