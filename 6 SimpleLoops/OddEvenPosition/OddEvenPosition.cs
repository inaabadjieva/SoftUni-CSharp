using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var oddsum = 0.0; 
            var oddmin = 1000000.0;
            var oddmax = -1000000.0;
            var evensum = 0.0;
            var evenmin = 1000000.0;
            var evenmax = -1000000.0;
            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddsum += num;
                    if (num > oddmax) oddmax = num;
                    if (num < oddmin) oddmin = num;                     
                }
                else 
                {
                    evensum += num;
                    if (num > evenmax) evenmax = num;
                    if (num < evenmin) evenmin = num;                    
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Oddsum = 0, Oddmin = No, Oddmax = No, Evensum = 0, Evenmin = No, Evenmax = No");
            }
            else if (n==1)
            {
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, Evensum = 0, Evenmin = No, Evenmax = No", oddsum, oddmin, oddmax);
            }
            else 
            {
                Console.WriteLine("Oddsum = {0}, Oddmin = {1}, Oddmax = {2}, Evensum = {3}, Evenmin = {4}, Evenmax = {5}", oddsum, oddmin, oddmax, evensum, evenmin, evenmax);
            }
            
        }
    }
}
