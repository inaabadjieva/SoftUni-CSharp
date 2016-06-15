using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            //GetMax(a,b);

            Console.WriteLine(Math.Max(GetMax(a,b),c));
        }

        static int GetMax(int x, int y)
        {
            int bigger = Math.Max(x, y);
            return bigger;
        }
    }
}
