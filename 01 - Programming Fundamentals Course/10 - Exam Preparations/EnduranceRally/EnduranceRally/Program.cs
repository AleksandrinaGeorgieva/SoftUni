using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        private static new List<Dictionary<string, string>> drivers = new List<Dictionary<string, string>>();
        private static string fuelParam = "FUEL";
        private static string zoneParam = "ZONE";
        private static string finishedParam = "FINISHED";
        private static string nameParam = "NAME";

        private static void CreateDriverProfile (string name)
        {
            var t = new Dictionary<string, string>();
            t[fuelParam] = ((int)name[0]).ToString();
            t[zoneParam] = "0";
            t[finishedParam] = "0";
            t[nameParam] = name;
            drivers.Add(t);
        }

        private static void PrintResults()
        {
            for (int i = 0; i < drivers.Count; i++)
            {
                if(double.Parse(drivers[i][finishedParam]) > 0)
                {
                    Console.WriteLine($"{drivers[i][nameParam]} - reached {drivers[i][zoneParam]}");
                }else
                {
                    double f = double.Parse(drivers[i][fuelParam]);
                    Console.WriteLine($"{drivers[i][nameParam]} - fuel left {f:f2}");
                }
            }
        }

        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var zones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var checkpoints = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            names.ForEach(x => CreateDriverProfile(x));


            for (int j = 0; j < drivers.Count; j++)
            {
                for (int i = 0; i < zones.Length; i++)
                {

                    if (double.Parse(drivers[j][finishedParam]) < 1)
                    {
                        double tempF = double.Parse(zones[i]);
                        double newFuel = double.Parse(drivers[j][fuelParam]);
                        if (checkpoints.Contains(i.ToString()))
                        {
                            newFuel += tempF;
                        }
                        else
                        {
                            newFuel -= tempF;
                        }

                        if (newFuel > 0)
                        {
                            double zone = double.Parse(drivers[j][zoneParam]);
                            zone++;
                            drivers[j][zoneParam] = zone.ToString();
                            drivers[j][fuelParam] = newFuel.ToString();
                        }
                        else
                        {
                            drivers[j][finishedParam] = "1";
                        }
                    }                    
                }
            }
            PrintResults();
        }
    }
}
