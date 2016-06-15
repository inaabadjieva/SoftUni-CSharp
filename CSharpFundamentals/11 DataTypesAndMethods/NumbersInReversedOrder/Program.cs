using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

           ReversedNum(num);
        }

        static void ReversedNum(string number)
        {
            string reversed = "";
            int length = number.Length - 1;
            while (length >= 0)
            {
                reversed = reversed + number[length];
                length--;
            }
            Console.WriteLine(reversed);
        }
    }
}
