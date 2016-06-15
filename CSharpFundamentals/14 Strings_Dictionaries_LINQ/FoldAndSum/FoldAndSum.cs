using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = nums.Length / 4;
            var newLeft = nums.Take(k).Reverse();
            var newRight = nums.Reverse().Take(k);
            int[] first = newLeft.Concat(newRight).ToArray();
            int[] second = nums.Skip(k).Take(2 * k).ToArray();
            var sum = first.Select((x, index) => (x + second[index]));
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
