using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Point
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        public static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() { X = coords[0], Y = coords[1] };
            return p;
        }

        //public override string ToString()
        //{
        //    return String.Format("{0}({1}, {2})", this.Name, this.X, this.Y);
        //}
    }

    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            var p1 = Point.ReadPoint();
            var p2 = Point.ReadPoint();
            var dist = Point.CalcDistance(p1, p2);
            Console.WriteLine("{0:f3}", dist);
        }   
    }
}
