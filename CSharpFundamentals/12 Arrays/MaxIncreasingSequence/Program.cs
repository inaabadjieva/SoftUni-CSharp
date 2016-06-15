using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCount = 0;
            int startIndex = 0;
            int count = 0;
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    count++;
                    index = i - count;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        startIndex = index;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = startIndex; i <= startIndex + maxCount; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
