using System;
using BusesAndStops.Models;
namespace BusesAndStops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < q; ++i)
            {
                string command = Console.ReadLine();
                Query.ProcessQuery(command);
            }
        }
    }
}
