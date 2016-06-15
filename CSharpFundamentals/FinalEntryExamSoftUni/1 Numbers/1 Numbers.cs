using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var average = nums.Average();
            var greater = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] > average)
                {
                    greater.Add(nums[i]);
                }
            }
            if (greater.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (greater.Count >= 5)
            {
                var result = greater.OrderByDescending(x => x).Take(5);
                Console.WriteLine(string.Join(" ", result));
            }
            else if (greater.Count < 5)
            {
                Console.WriteLine(string.Join(" ", greater.OrderByDescending(x => x)));
            }         
        }
    }
}
