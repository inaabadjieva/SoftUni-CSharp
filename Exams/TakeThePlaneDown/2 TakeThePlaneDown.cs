using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeThePlaneDown
{
    class TakeThePlaneDown
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int countryRadius = int.Parse(Console.ReadLine());

            int detectedPlanes = int.Parse(Console.ReadLine());
            for (int plane = 0; plane < detectedPlanes; plane++)
            {
                int PlaneX = int.Parse(Console.ReadLine());
                int PlaneY = int.Parse(Console.ReadLine());

                int planeDistanceX = PlaneX - x;
                int planeDistanceY = PlaneY - y;
               
                double distanceToPlane = Math.Abs(planeDistanceX) + Math.Abs(planeDistanceY);

                if(distanceToPlane < countryRadius )

                Console.WriteLine("You destroyed a plane at [{0},{1}]", PlaneX,PlaneY );
             }
         
        }
    }
}
