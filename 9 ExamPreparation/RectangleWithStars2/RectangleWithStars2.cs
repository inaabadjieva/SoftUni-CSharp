using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars2
{
    class RectangleWithStars2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', 2 * n));
            int numRows = n - 1;
            if (n % 2 == 1) numRows++;
            for ( int row = 1; row <= numRows; row++)
            {
                if (row == (numRows + 1)/2)
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (2*n - 4)/2));
                    Console.Write("**");
                    Console.Write(new string(' ', (2*n - 4)/2));
                    Console.Write("%");
                }
                else
                {
                    Console.Write("%");
                    Console.Write(new string(' ', 2*n - 2));
                    Console.Write("%");
                }
                
            Console.WriteLine();
            }    
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
