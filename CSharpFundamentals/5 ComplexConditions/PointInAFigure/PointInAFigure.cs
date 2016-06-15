using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInAFigure
{
    class PointInAFigure
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var inside1 = (x > 0) && (x < 3*h) && (y > 0) && (y < h);
            var inside2 = (x > h) && (x < 2*h) && (y > h) && (y < 4*h);
            var inside3 = (x > h) && (x < 2 * h) && y == h;

            var border1 = x>=0 && y==0 && x<=3*h || x==3*h && y>=0 && y<=h || x>=2*h && x<=3*h && y==h || x>=0 && x<=h && y==h || x==0 && y>=0 && y <=h;
            var border2 = x == h && y >= h && y <= 4 * h || x >= h && x <= 2 * h && y == 4 * h || x == 2 * h && y >= h && y <= 4 * h;  

            if (inside1 || inside2 || inside3)
            {
                Console.WriteLine("inside");
            }
            else if (border1 || border2)
            {
                Console.WriteLine("border");
            }
            else 
            {
                Console.WriteLine("outside");
            }
        }
    }
}
