using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            var pos = 0;
            while (pos < nums.Count)
                {
                    int num = nums[pos]; int count = 1;
                    while(pos + count < nums.Count && nums[pos+count] == num)
                    count++;
                pos= pos + count;
                Console.WriteLine("{0} -> {1}", num, count);
                }   
        }
    }
}
