using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_BitsShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num1 = uint.Parse(Console.ReadLine());
            uint num2 = uint.Parse(Console.ReadLine());
            ulong result = 0;
            if (num1 >= num2)
            {
                for (int i = 31; i >= 0; i--)
                {
                    result = (result << 1) | ((num1 >> i) & 1);
                    result = (result << 1) | ((num2 >> i) & 1);
                }
            }
            else
            {
                for (int i = 31; i >= 0; i-=2)
                {
                    result = (result << 1) | ((num1 >> i) & 1);
                    result = (result << 1) | ((num1 >> i - 1) & 1);
                    result = (result << 1) | ((num2 >> i) & 1);
                    result = (result << 1) | ((num2 >> i - 1) & 1);
                }
            }
            Console.WriteLine(result);
        }
    }
}
