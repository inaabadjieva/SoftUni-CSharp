using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var count = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                    count[num]++;
                else
                    count[num] = 1;
            }
            foreach (var num in count.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, count[num]);
            }
        }
    }
}
