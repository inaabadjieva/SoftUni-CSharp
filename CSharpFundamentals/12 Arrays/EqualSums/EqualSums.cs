using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool equalSums = false;
            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    equalSums = true;
                }
            }
            if (equalSums == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
