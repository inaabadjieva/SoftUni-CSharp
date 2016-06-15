using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_TeleportPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointA = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var pointB = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var pointC = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var pointD = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            
            double aX = pointA[0];
            double aY = pointA[1];
            double bX = pointB[0];
            double bY = pointB[1];
            double cX = pointC[0];
            double cY = pointC[1];
            double dX = pointD[0];
            double dY = pointD[1];

            int pointCounter = 0;

            for (double x = 0; x <= radius; x += step)
            {
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                            pointCounter++;
                    }
                }
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                            pointCounter++;
                    }
                }
            }
            for (double x = -step; x >= -radius; x -= step)
            {
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                            pointCounter++;
                    }
                }
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                            pointCounter++;
                    }
                }
            }

            Console.WriteLine(pointCounter);
        }
    }
}
