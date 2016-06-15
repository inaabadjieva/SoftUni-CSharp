using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOf_n_n_Stars
{
    class RectangleOf_n_n_Stars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('*',n));
                
                //for (int col = 0; col < n; col++)
                //{
                //    Console.Write("*");
                //}
                //Console.WriteLine();
            }
        }
    }
}
