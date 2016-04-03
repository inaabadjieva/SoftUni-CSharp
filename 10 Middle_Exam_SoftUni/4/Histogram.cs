using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var sum4 = 0;
            var sum5 = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200) sum1++;
                else if (num <400) sum2 ++;
                else if (num < 600) sum3 ++;
                else if (num < 800) sum4 ++;
                else sum5 ++;
                
            }
            Console.WriteLine(Math.Round(sum1/n*100,2) + "%");
            Console.WriteLine(Math.Round(sum2 / n * 100, 2) + "%");
            Console.WriteLine(Math.Round(sum3 / n * 100, 2) + "%");
            Console.WriteLine(Math.Round(sum4 / n * 100, 2) + "%");
            Console.WriteLine(Math.Round(sum5 / n * 100, 2) + "%");
        }
    }
}
