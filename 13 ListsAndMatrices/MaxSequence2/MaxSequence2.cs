using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence2
{
    class MaxSequence2
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var start = 0;
           
            var maxCount = 0;
            var result = new List<int>();
            while (start < nums.Count)
            {
                var count = 1;
                int num = nums[start];
               
                while (start + count < nums.Count && num == nums[start + count])
                {
                    count++;
                }
               if (maxCount < count)
                {
                   maxCount = count;
                   result = nums.GetRange(start, count);
                }
                start = start + count;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
