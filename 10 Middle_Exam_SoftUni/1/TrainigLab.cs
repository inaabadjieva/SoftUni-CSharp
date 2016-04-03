using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var rows = Math.Truncate((length * 100) / 120);
            var desksPerRow = Math.Truncate((width * 100 - 100) / 70); 
            var desks = rows * desksPerRow - 3;
            Console.WriteLine(desks);

        }
    }
}
