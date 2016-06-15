using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sortedNums = nums.OrderByDescending(x => x);
            var largestNums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largestNums));
        }
    }
}
