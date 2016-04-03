using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareofStars
{
    class SquareofStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                   
                    if (i==1||i==n)
                    {
                        Console.Write("*");
                    }
                    else if (j==1||j==n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                   
                }
                Console.WriteLine();

            }  
        }
    }
}
