using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                roundedNums[i] = (int) Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} -> {1}", array[i], roundedNums[i]);
            }

        }
    }
}
