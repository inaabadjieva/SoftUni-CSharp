using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Biggest_Tripple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            int sumMax = int.MinValue;
            int start = 0;

            for (int i = 0; i < nums.Length; i+=3)
            {
                int sum = trippleSum(nums, i);
                if (sum > sumMax)
                {
                    sumMax = sum;
                    start = i;
                }
                    
            }
            for (int iii = start; iii < start+3; iii++)
            {
                if (iii < nums.Length)
                    Console.Write(nums[iii] + " ");
            }
        }
        static int trippleSum(int[] numbers, int i)
        {
            int sum1 = 0;
            for (int ii = i; ii < i + 3; ii++)
            {
                if (ii < numbers.Length)
                {
                    sum1 += numbers[ii];
                }
            }
            return sum1;
        }
    }
}
