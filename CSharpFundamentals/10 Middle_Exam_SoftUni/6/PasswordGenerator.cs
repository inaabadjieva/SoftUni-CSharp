using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); 
            var num2 = int.Parse(Console.ReadLine());
            string[] alphabet = { "a","b", "c", "d", "e", "f", "g", "h", "i" };

            for (int symbol1 = 1; symbol1 <= n; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= n; symbol2++)
                {
                    for (int symbol3 = 0; symbol3 < num2; symbol3++)
                    {
                        for (int symbol4 = 0; symbol4 < num2; symbol4++)
                        {
                            for (int symbol5 = 1; symbol5 <= n; symbol5++)
                            {
                                if (symbol5 > symbol1 && symbol5 > symbol2)
                                {
                                Console.Write("{0}{1}", symbol1, symbol2);
                                Console.Write(alphabet[symbol3]);
                                Console.Write(alphabet[symbol4]);
                                Console.Write("{0} ", symbol5);
                                }
                                
                            }
                        } 
                    }   
                }
            }
        }
    }
}
