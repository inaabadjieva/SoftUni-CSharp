using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LastDigitName
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(LastDigit(num));
        }

        static string LastDigit(string num)
        {
            string name = "";
            char lastDigit = num[num.Length-1];
            switch (lastDigit)
            {
                case '1': name = "one"; break;
                case '2': name = "two"; break;
                case '3': name = "three"; break;
                case '4': name = "four"; break;
                case '5': name = "five"; break;
                case '6': name = "six"; break;
                case '7': name = "seven"; break;
                case '8': name = "eight"; break;
                case '9': name = "nine"; break;
                default: name = "zero"; break;
            }
            return name;
        }
    }
}
