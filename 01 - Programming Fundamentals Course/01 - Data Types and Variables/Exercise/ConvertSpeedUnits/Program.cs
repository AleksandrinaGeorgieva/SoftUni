using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInSeconds = seconds + 60 * (minutes + (hours * 60));
            float timeInHours = hours + (minutes + (seconds / 60.0f)) / 60.0f;
            float metersInSecondsSpeed = distance / timeInSeconds;

            Console.WriteLine("{0:0.#######}", metersInSecondsSpeed);
            Console.WriteLine("{0:0.#######}", (distance / 1000.0f) / timeInHours);
            Console.WriteLine("{0:0.#######}", (distance / 1609.0f) / timeInHours);
                      
        }
    }
}
