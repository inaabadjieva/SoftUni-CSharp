using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n%2==0)
            { 
                for (int row = 1; row <= n+1; row++)
			    {
			        if(row==1 || row == n+1)
                        Console.Write(new string('%', 2 * n));

                    else if (row == (n + 2) / 2)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', (2 * n - 4)/2));
                        Console.Write("**");
                        Console.Write(new string(' ', (2 * n - 4) / 2));
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.Write("%");
                    }
                Console.WriteLine();      
			    }
            }
            else
            {
                for (int row = 1; row <= n + 2; row++)
                {
                    if (row == 1 || row == n + 2)
                        Console.Write(new string('%', 2 * n));

                    else if (row == (n + 3) / 2)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', (2 * n - 4) / 2));
                        Console.Write("**");
                        Console.Write(new string(' ', (2 * n - 4) / 2));
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', 2 * n - 2));
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
