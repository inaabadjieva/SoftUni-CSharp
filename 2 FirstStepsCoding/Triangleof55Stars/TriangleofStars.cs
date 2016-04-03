using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangleof55Stars
{
    class TriangleofStars
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int i = 1; i <=a; i++)
                {    
                    Console.Write("*");
                } 
                Console.WriteLine();
            }
        }
    }
}
