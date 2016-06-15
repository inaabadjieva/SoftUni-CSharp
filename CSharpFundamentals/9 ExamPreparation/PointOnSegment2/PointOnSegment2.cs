using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment2
{
    class PointOnSegment2
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());
            var leftEnd = Math.Min(first, second);
            var rightEnd = Math.Max(first, second);
            var pointOnSegment = (point >= leftEnd) && (point <= rightEnd);
            var leftDistance = Math.Abs(leftEnd - point);
            var rightDistance = Math.Abs(rightEnd - point);
            if (pointOnSegment) Console.WriteLine("in");
            else Console.WriteLine("out");
            Console.WriteLine(Math.Min(leftDistance,rightDistance));
        }
    }
}
