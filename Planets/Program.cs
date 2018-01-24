using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.AddRange(new List<string> { "Jupiter", "Saturn" });

            List<string> morePlanets = new List<string>() { "Neptune", "Pluto" };
            planetList.AddRange(morePlanets);

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadLine();
        }
        
    }
}
