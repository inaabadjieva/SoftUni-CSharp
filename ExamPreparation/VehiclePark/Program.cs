using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vehicles = Console.ReadLine().Split(' ').ToList();
            var input = Console.ReadLine();

            var count = 0;
            while (input != "End of customers!")
            {
                string[] data = input.Split(' ');
                string requests = data[0].ToLower()[0] + data[2];
                int wantedIndex = -1;
                
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i] == requests)
                    {
                        wantedIndex = i;
                        break;
                    }
                }

                if (wantedIndex == -1)
                    Console.WriteLine("No");
                else
                {
                    string vehicle = vehicles[wantedIndex];
                    int price = vehicle[0] * int.Parse(vehicle.Substring(1, vehicle.Length - 1));
                    Console.WriteLine("Yes, sold for {0}$", price);
                    vehicles.RemoveAt(wantedIndex);
                    count++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Vehicles left: {0}", string.Join(", ", vehicles));
            Console.WriteLine("Vehicles sold: {0}", count);
        }
    }
}
