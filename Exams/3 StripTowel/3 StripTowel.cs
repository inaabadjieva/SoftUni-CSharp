using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_StripTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            double length = Math.Floor(width * 1.5);

            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    bool isStripe = (row + col) % 3 == 0;
                    if (isStripe) Console.Write("#");
                    else Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
