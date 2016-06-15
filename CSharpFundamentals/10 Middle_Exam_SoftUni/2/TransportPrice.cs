using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine().ToLower();

            var dayWithTaxi = 0.79 * distance + 0.70;
            var nightWithTaxi = 0.90 * distance +0.70;
            var busPrice = 0.09*distance;
            var trainPrice = 0.06*distance;

            if (distance < 20)
            {
                if (dayOrNight == "day") Console.WriteLine(dayWithTaxi);
                else if (dayOrNight == "night") Console.WriteLine(nightWithTaxi);
            }
            else if (distance<100)
            {
                Console.WriteLine(busPrice);
            }
            else if (distance >= 100)
            {
                Console.WriteLine(0.06*distance);
            }
        }
    }
}
