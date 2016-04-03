using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
