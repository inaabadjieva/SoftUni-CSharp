using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            var y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1,x2) - Math.Min(x1,x2);
            double length = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine(width * length);
            Console.WriteLine(2 * (width + length));
        }
    }
}
