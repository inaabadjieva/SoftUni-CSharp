using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class LastKNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;
            for (int current = 1; current < n; current++)
            {
                long sum = 0;
                for (int prev = current - k; prev <= current - 1; prev++)
                {
                    if(prev>=0)
                    sum += arr[prev];
                    arr[current] = sum;
                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ");

        }
    }
}
