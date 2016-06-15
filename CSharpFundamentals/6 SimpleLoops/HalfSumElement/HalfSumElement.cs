using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
           
            if (sum - max == max)
            {
                Console.WriteLine("Yes sum " + max);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs((sum - max) - max));
            }
        }
    }
}
