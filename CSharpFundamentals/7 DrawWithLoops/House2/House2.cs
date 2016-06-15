using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House2
{
    class House2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0) stars++;
            for (int row = 0; row < (n+1)/2; row++)
            {
                var padding = (n - stars) / 2;
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', padding));
                stars = stars + 2;
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                for (int col = 0; col < n - 2; col++)
                    Console.Write("*");
                Console.WriteLine("|");
            }           
        }
    }
}
