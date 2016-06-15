using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEqualSequence
{
    class MaxEqualSequence
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            int start = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    start = i;
                }
                length = 1;
            }
            for (int i = start; i < start + bestLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
