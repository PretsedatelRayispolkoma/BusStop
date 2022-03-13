using System;
using System.Collections.Generic;

namespace BusStop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, HashSet<string>> buses = new Dictionary<string, HashSet<string>>();

            string[] commands = new string[q];

            for(int i = 0; i < q; ++i)
            {
                commands[i] = Console.ReadLine();
            }

            string commandItem;
            string busesInCurrentStop;

            foreach (var command in commands)
            {
                commandItem = command;
                string[] stringCommand = commandItem.Split(' ');
                HashSet<string> stopsList = new HashSet<string>();
                for (int i = 0; i < stringCommand.Length; ++i)
                {
                    if(stringCommand[0] == "NEW_BUS")
                    {
                        int countOfStops = Convert.ToInt32(stringCommand[2]);
                        for (int j = 3; j < countOfStops + 3; ++j)
                        {
                            stopsList.Add(stringCommand[j]);
                        }
                        
                    }
                    if(stringCommand[0] == "BUSES_FOR_STOP")
                    {
                    }
                }
                buses.Add(stringCommand[1], stopsList);

                Console.WriteLine();
            }
        }
    }
}
