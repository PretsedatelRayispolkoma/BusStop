using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusesAndStops.Models
{
    public class AllBuses : Bus
    {
        public List<string> GetAllBuses(Bus bus)
        {
            List<string> allRoutes = new List<string>();

            SortedDictionary<string, HashSet<string>> sortedRoutes = new SortedDictionary<string, HashSet<string>>(bus.busesDict);

            string stopsLine = "";

            if (sortedRoutes.Count != 0)
            {
                foreach (var route in sortedRoutes)
                {
                    foreach (var stop in route.Value)
                        stopsLine += $"{stop}";
                    allRoutes.Add($"{route.Key}: {stopsLine}");
                }
            }
            else
            {
                allRoutes.Add("No buses");
            }

            return allRoutes;
        }

        //public override string ToString()
        //{
        //    return string.Join(Environment.NewLine, GetAllBuses().ToArray());
        //}
    }
}
