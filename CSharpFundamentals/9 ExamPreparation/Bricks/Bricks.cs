using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var bricks = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            
            var formula = bricks / (workers * m);
            Console.WriteLine(Math.Ceiling(formula));
           
        }
    }
}
