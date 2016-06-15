using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var length = 0;
            var maxLength = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                    length++; 
                else
                    length = 1;
                if (length > maxLength) maxLength = length;
                max = num;
            }
            Console.WriteLine(maxLength);
        }
    }
}
