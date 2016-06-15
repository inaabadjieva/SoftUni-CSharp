using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceEqualElements
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
     
            var start = 0;
            var count = 1;
            var maxCount = 0;
            var result = new List<int>();
            while (start < nums.Count)
            {
                int num = nums[start];
                while (num == nums[start + count] && start < nums.Count)
                {
                    count++;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    result = nums.GetRange(start,count);
                }
                start = start + count;
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
