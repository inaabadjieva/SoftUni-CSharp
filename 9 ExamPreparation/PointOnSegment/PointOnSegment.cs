using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());
            var space1 = Math.Abs(first - point);
            var space2 = Math.Abs(second - point);
            if (point >= first && point <= second || point <= first && point >= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
            if (space1 < space2)
            {
                Console.WriteLine(space1);
            }
            else
            {
                Console.WriteLine(space2);
            }

        }
    }
}
