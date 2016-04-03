using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                if (row == 0)
                {
                    Console.Write("/");
                    Console.Write(new string('^', n / 2));
                    Console.Write("\\");
                    Console.Write(new string('_',2*n - 2*(n/2) - 4));
                    Console.Write("/");
                    Console.Write(new string('^', n / 2));
                    Console.Write("\\");
                 }
                else if (row == n - 1)
                {
                    Console.Write("\\");
                    Console.Write(new string('_', (n / 2)));
                    Console.Write("/");
                    Console.Write(new string(' ', 2 * n - 2 * (n / 2) - 4));
                    Console.Write("\\");
                    Console.Write(new string('_', (n / 2)));
                    Console.Write("/");
                }
                else if (row == n - 2)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', n/2 + 1));
                    Console.Write(new string('_', 2 * n - 2 * (n / 2) - 4));
                    Console.Write(new string(' ', n/2 + 1));
                    Console.Write("|");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', 2*n - 2));
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            
        }
    }
}
