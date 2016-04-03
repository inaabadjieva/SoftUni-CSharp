using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Inside_OutsideFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPointInTheBuilding(x1, y1, h));
            Console.WriteLine(IsPointInTheBuilding(x2, y2, h));
            Console.WriteLine(IsPointInTheBuilding(x3, y3, h));
            Console.WriteLine(IsPointInTheBuilding(x4, y4, h));
            Console.WriteLine(IsPointInTheBuilding(x5, y5, h));
        }

        private static string IsPointInTheBuilding(int x, int y, int h)
        {
            bool insideDown =
                (x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h);
            bool insideUp =
                (x >= h) && (x <= 2 * h) && (y >= h) && (y <= 4 * h);
            bool inside = insideDown | insideUp;
            string result = inside ? "inside" : "outside";
            return result;
        }


    }
}
