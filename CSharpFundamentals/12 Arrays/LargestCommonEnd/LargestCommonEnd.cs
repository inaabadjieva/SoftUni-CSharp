using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static int largestCommonEnd(string[] first, string[] second)
        {
            //right to left
            var rightCount = 0;
            while (rightCount < first.Length &&
                   rightCount < second.Length)
            {
                if (first[first.Length - rightCount - 1] ==
                     second[second.Length - rightCount - 1])
                    rightCount++;
                else break;
            }
            
            //left to right
            var leftCount = 0;
            while (leftCount < first.Length &&
                  leftCount < second.Length)
            {
                if (first[leftCount] ==
                     second[leftCount])
                    leftCount++;
                else break;
            }
            return Math.Max(leftCount,rightCount);
          

        }
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ').ToArray();
            string[] second = Console.ReadLine().Split(' ').ToArray();
            var result = largestCommonEnd(first, second);
            Console.WriteLine(result);
            
        }
       
    }
}
