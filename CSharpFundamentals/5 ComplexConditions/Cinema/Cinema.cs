using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var movie = Console.ReadLine().ToLower();
            var r = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());

            if (movie == "premiere")
            {
                Console.WriteLine("{0:f2}", r * s * 12);
            }
            else if (movie == "normal")
            {
                Console.WriteLine("{0:f2}", r * s * 7.5);
            }
            else if (movie == "discount")
            {
                Console.WriteLine("{0:f2}", r * s * 5);
            }
        }
    }
}
