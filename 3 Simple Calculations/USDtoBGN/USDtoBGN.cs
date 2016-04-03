using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(USD * 1.79549, 2) + " BGN");
        }
    }
}
