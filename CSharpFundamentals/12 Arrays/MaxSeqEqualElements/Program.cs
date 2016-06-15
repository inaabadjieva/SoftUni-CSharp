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
            int bestNum = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                }
                if (bestLength < length)
                {
                    bestLength = length;
                    bestNum = array[i];
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(bestNum + " ");
            }
        }
    }
}
