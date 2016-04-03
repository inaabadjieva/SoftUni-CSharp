using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ImpressTheGirlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            uint rubles = uint.Parse(Console.ReadLine());
            uint dollars = uint.Parse(Console.ReadLine());
            uint euros = uint.Parse(Console.ReadLine());
            uint B = uint.Parse(Console.ReadLine())/2;
            uint M = uint.Parse(Console.ReadLine());

            //decimal R = (priceInR  100M  3.5M);
            //decimal D = (priceInD  1.5M);
            //decimal E = (priceInE  1.95M);
            //decimal B = (priceInB  2M);

            double rubleInLeva = rubles * 0.035;
            double dollarsInLeva = dollars * 1.5;
            double euroInLeva = euros * 1.95;
            

            double mostExpensive = Math.Ceiling(Math.Max(B, Math.Max(M, Math.Max(rubleInLeva, Math.Max(dollarsInLeva, euroInLeva)))));
            Console.WriteLine("{0:f2}",mostExpensive);
        }
    }
}
