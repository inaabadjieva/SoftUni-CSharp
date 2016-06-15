using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers
{
    class Increasing4Numbers
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b - a < 3) Console.WriteLine("No");
            for (int first = a; first <= b; first++)
            {
                for (int second = a + 1; second <= b; second++)
                {
                    for (int third = a + 2; third <= b; third++)
                    {
                        for (int fourth = a + 3; fourth <= b; fourth++)
                        {
                            if(first<second && second<third && third<fourth)
                            Console.WriteLine("{0} {1} {2} {3}", first, second, third, fourth);

                        }
                    }
                }
            }
        }
    }
}
