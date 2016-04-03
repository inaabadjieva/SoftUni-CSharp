using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holidays = double.Parse(Console.ReadLine());
            var weekends = double.Parse(Console.ReadLine());
            var result = 0.0;
                result = (((3.0* (48 - weekends))/4) + (2.0*holidays)/3 + weekends);
                if (year == "leap")
                {
                    Console.WriteLine(Math.Truncate(result + 0.15 * result));
                }
                else 
                {
                    Console.WriteLine(Math.Truncate(result));
                }
        }
    }
}
