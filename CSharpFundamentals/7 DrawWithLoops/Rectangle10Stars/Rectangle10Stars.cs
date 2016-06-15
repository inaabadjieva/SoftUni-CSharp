using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle10Stars
{
    class Rectangle10Stars
    {
        static void Main(string[] args)
        {
            var n = 10;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("*");                                        
                } 
                Console.WriteLine();
            }
            
        }
    }
}
