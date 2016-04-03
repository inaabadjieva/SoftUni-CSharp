using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = Math.Max(arr2.Length, arr1.Length);
            var sumArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(i);
                Console.WriteLine(i % arr2.Length);
                sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
