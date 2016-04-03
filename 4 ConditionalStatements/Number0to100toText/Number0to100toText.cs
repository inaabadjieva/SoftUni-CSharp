using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0to100toText
{
    class Number0to100toText
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string[] tonineteen = { "zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] toninety = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num < 0 || num > 100)
                {
                    Console.WriteLine("invalid number");
                }
                else if (num >=1 && num<=19)
                {
                Console.WriteLine(tonineteen[num]);
                }
                else if (num>=20 && num < 100)
                {
                    if (num%10 == 0)
                    {
                        Console.WriteLine(toninety[(num / 10) - 2]);
                    }
                    else
                    {
                        Console.WriteLine(toninety[(num / 10) - 2] +" "+ tonineteen[(num % 10)]);
                    }
                }
                else if (num == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (num == 0)
                {
                    Console.WriteLine("zero");
                }
            }
        }
    }

