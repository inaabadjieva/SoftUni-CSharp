using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_WaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal water = decimal.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            int bottlesLeft = bottles.Length;
            int index = 0;
            bool noWater = false;
            decimal litersNeeded = 0;

            if (water % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    water -= capacity - bottles[i];
                    
                    index = i;
                   
                    if (water < 0)
                    {
                        litersNeeded += capacity - bottles[i];
                        noWater = true;
                    }
                    else
                    {
                        bottlesLeft--; 
                    }
                }
                if (noWater == true)
                {
                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", bottlesLeft);
                    Console.Write("With indexes: ");
                    for (int j = index; j < bottles.Length; j++)
                    {
                        if (j != bottles.Length - 1)
                            Console.Write(j + ", ");
                        else
                            Console.Write(j);
                    }
                    Console.WriteLine();
                    Console.WriteLine("We need {0} more liters!", litersNeeded);
                }
                else
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", water);
                }    
            }
            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    water -= capacity - bottles[i];
                    index = i;

                    if (water < 0)
                    {
                        litersNeeded += capacity - bottles[i];
                        noWater = true;
                    }
                    else
                    {
                        bottlesLeft--;
                    }
                }
                if (noWater == true)
                {
                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", bottlesLeft);
                    Console.Write("With indexes: ");
                    for (int j = index; j >= 0; j--)
                    {
                        if (j != 0)
                            Console.Write(j + ", ");
                        else            
                            Console.Write(j);                 
                    }
                    Console.WriteLine();
                    Console.WriteLine("We need {0} more liters!", litersNeeded);
                }
                else
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", water);
                }
            }           
        }
    }
}
