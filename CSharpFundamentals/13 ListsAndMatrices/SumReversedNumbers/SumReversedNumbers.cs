using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToList();
            StringBuilder reversed = new StringBuilder();
            long sum = 0;
            foreach (var num in nums)
            {
                for (int i = num.Length - 1; i >= 0; i--)
                {
                    reversed.Append(num[i]);
                }
                sum += long.Parse(reversed.ToString());
                reversed.Clear();
            }

            Console.WriteLine(sum);
        }
    }
}
