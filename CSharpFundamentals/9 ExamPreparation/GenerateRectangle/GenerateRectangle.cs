using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangle
{
    class GenerateRectangle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minArea = int.Parse(Console.ReadLine());
            var printNo = true;
            for (int top = -n; top <= n; top++)
            {
                for (int left = -n; left <= n; left++)
                {
                    for (int bottom = top + 1; bottom <= n; bottom++)
                    {
                        for (int right = left + 1; right <= n; right++)
                        {
                            var sideX = right - left;
                            var sideY = top - bottom;
                            var area = Math.Abs(sideX*sideY);
                            if (area >= minArea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                printNo = false;
                            }
                        }
                    }
                } 
            }
            if(printNo)
            Console.WriteLine("No");
        }
    }
}
