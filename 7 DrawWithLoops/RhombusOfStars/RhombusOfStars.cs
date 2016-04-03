using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = 2; row <= n; row++)
            {
                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
