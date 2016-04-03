using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrom(i) && SumOfDigits(i) && EvenDigits(i))
                    Console.WriteLine(i);                
            }

        }
        static bool IsPalindrom (int num)
            {
                    string digits = "" + num;
                    for (int i = 0; i < digits.Length/2; i++)
                    {
                        if (digits[i] != digits[digits.Length - i -1])
                            return false;
                    }
                    return true;
			 
            }
        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while(num>0)
            {
                sum += num%10;
                num = num / 10; 
            }
            if (sum % 7 == 0)
                return true;
            else
                return false;
        }
        static bool EvenDigits(int num)
        {
            string digits = "" + num;
            for (int i = 0; i < digits.Length; i++)
			    {
			        int digit = digits[i];
                    if(digit%2==0)
                    return true;
			    }
            return false;
        }
    }
}
