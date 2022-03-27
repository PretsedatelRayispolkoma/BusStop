using BusAndStop.Models;
using System;

namespace BusAndStop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= q; i++)
            {
                string query = Console.ReadLine();
                QueryManager.QueryProcessing(query);
            }
        }
    }
}
