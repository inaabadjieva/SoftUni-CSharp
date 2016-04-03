using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var inside1 = (x >= 4 && x <= 10 && y >= -5 && y <= -3);
            var inside2 = (x >= 2 && x <= 12 && y >= -3 && y <= 1);
            var inside3 = (x >= 4 && x <= 10 && y >= 1 && y <= 3);
            if (inside1 || inside2 || inside3)
                Console.WriteLine("in");
            else
                Console.WriteLine("out");

 
            

        }
    }
}
