using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < (n + 1) / 2; row++)
            { 
                 if (n % 2 == 0)
                {
                    if (row == 0)
                    {
                        for (int col = 0; col < (n - 2) / 2; col++)
                            Console.Write("-");
                        Console.Write("**");
                        for (int col = 0; col < (n - 2) / 2; col++)
                            Console.Write("-");
                    }
                    else
                    {
                        for (int col = 0; col < n / 2 - row - 1; col++)
                            Console.Write("-");
                        for (int col = 0; col < 2*row + 2; col++)
                            Console.Write("*");
                        for (int col = 0; col < n / 2 - row - 1; col++)
                            Console.Write("-");
                    }
                }
                 else
                 {
                     if (row == 0)
                     {
                         for (int col = 0; col < (n - 1) / 2; col++)
                             Console.Write("-");
                         Console.Write("*");
                         for (int col = 0; col < (n - 1) / 2; col++)
                             Console.Write("-");
                     }
                     else
                     {
                         for (int col = 0; col < n / 2 - row; col++)
                             Console.Write("-");
                         for (int col = 0; col < 2*row +1; col++)
                             Console.Write("*");
                         for (int col = 0; col < n / 2 - row; col++)
                             Console.Write("-");
                     }
                 }
                 Console.WriteLine();
            }


            for (int row = 0; row < n/2; row++)
            {
                Console.Write("|");
                for (int col = 0; col < n-2; col++)
                    Console.Write("*");
                Console.WriteLine("|");
            }
        }
    }
}
