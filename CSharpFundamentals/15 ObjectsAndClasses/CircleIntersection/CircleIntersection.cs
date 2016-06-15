using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleIntersection
{
    class Circle
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }

        public static Circle ReadCircle()
        {
            var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var circle = new Circle() { CenterX = coords[0], CenterY = coords[1], Radius = coords[2] };
            return circle;
        }
        public static double CalcCenterDistance(Circle c1, Circle c2)
        {
            var a = c1.CenterX - c2.CenterX;
            var b = c1.CenterY - c2.CenterY;
            var distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
    }
   
    class CircleIntersection
    {
        static void Main(string[] args)
        {
            var c1 = Circle.ReadCircle();
            var c2 = Circle.ReadCircle();

            var distance = Circle.CalcCenterDistance(c1, c2);
            if (distance <= c1.Radius + c2.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
