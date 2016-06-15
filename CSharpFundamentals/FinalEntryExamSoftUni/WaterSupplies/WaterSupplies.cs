using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottlesFilling
{
    class Program
    {
        static void Main()
        {
            var water = int.Parse(Console.ReadLine());
            decimal[] bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            int bottleCapacity = int.Parse(Console.ReadLine());

            var indexesOfLeftBottles = new List<int>();
            var bottlesLeft = 0;        
            decimal litersNeeded = 0;

            if (water % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    litersNeeded += bottleCapacity - bottles[i];
                    if (litersNeeded > water)
                    {
                        bottlesLeft++;
                        indexesOfLeftBottles.Add(i);
                    }
                }
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    litersNeeded += bottleCapacity - bottles[i];
                    if (litersNeeded > water)
                    {
                        bottlesLeft++;
                        indexesOfLeftBottles.Add(i);
                    }
                }
            }
            if (litersNeeded > water)
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottlesLeft}");
                Console.WriteLine($"With indexes: {string.Join(", ", indexesOfLeftBottles)}");
                Console.WriteLine($"We need {litersNeeded - water} more liters!");
            }
            else
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {water - litersNeeded}l.");
            }


        }

    }
}