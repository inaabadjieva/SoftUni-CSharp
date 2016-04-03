using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var LeftRight = (n - 1) / 2;
            for (int row = 1; row <= (n-1)/2; row++)
            {
                Console.Write(new string('-', LeftRight));
                Console.Write("*");
                var mid = n - 2 * LeftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', LeftRight));
                LeftRight--;
            }
            for (int row = 0; row <= (n-1)/2; row++)
            {
                Console.Write(new string('-', LeftRight));
                Console.Write("*");
                var mid = n - 2 * LeftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', LeftRight));
                LeftRight++;
            }
        }
    }
}

