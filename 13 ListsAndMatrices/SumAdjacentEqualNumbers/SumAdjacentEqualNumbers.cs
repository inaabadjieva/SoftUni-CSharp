using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int position = 0;
            while (position < nums.Count - 1)
            {
                if (nums[position] == nums[position + 1])
                { 
                    nums[position] = nums[position] + nums[position + 1];
                    nums.RemoveAt(position + 1);
                    position--;
                    if (position < 0) position = 0;
                }
                else
                    position++;
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
