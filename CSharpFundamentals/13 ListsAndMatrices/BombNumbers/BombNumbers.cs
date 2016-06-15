using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] bombNums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long bombNum = bombNums[0];
            long left = bombNums[1];
            long right = bombNums[1];
           
            for (long i = 0; i < nums.Length; i++)
            {             
                if (nums[i] == bombNum)
                {
                    long start = i - left;
                    long end = i + right;
                    if (end > nums.Length - 1)
                    {
                        right = nums.Length - i - 1;
                    }
                    if (start < 0)
                    {
                        start = 0;
                        for (long j = start; j <= i+right; j++)
                        {
                            nums[j] = 0;
                        }
                        //nums.RemoveRange(start, (i-start) + right + 1);
                    }
                    else
                    {
                        for (long j = start; j <= i + right; j++)
                        {
                            nums[j] = 0;
                        }
                       // nums.RemoveRange(start, left + right + 1);
                    }    
                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
