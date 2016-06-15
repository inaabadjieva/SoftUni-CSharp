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

        public static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = new Point() { X = coords[0], Y = coords[1] };
            return p;
        }

        public static Point[] ReadArrayOfPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = Point.ReadPoint();
            }
            return points;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.X - p2.X;
            var b = p1.Y - p2.Y;
            var distance = Math.Sqrt(a * a + b * b);
            return distance;
        }

        public static Point[] FindClosestPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            var nearestPoints = new Point[] { };

            for (int first = 0; first < points.Length; first++)
            {
                for (int second = first + 1; second < points.Length; second++)
                {
                    var p1 = points[first];
                    var p2 = points[second];
                    var distance = Point.CalcDistance(p1, p2);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        nearestPoints = new Point[] { p1, p2 };
                    }
                }
            }
            return nearestPoints;
        }
        public override string ToString()
        {
            return String.Format("{0}({1}, {2})", this.Name, this.X, this.Y);
        }
    }

    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            var points = Point.ReadArrayOfPoints();
            
            var closestPoints = Point.FindClosestPoints(points);
            Console.WriteLine("{0:f3}", Point.CalcDistance(closestPoints[0], closestPoints[1]));
            Console.WriteLine(closestPoints[0]);
            Console.WriteLine(closestPoints[1]);
        } 
    }
}
