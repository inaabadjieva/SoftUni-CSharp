using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GrandTheftExamo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long allBeers = 0;
            long slapped = 0;
            long escaped = 0;
            for (int i = 0; i < n; i++)
            {
                int thieves = int.Parse(Console.ReadLine());
                int beers = int.Parse(Console.ReadLine());
                if (thieves > 5)
                {
                    escaped += thieves - 5;
                    slapped+=5;
                    allBeers += beers;   
                }
                else
                {
                    slapped += thieves;
                    allBeers += beers;
                }
                
            }
            Console.WriteLine("{0} thieves slapped.", slapped);
            Console.WriteLine("{0} thieves escaped.", escaped);
            Console.WriteLine("{0} packs, {1} bottles.", allBeers/6, allBeers%6);
        }
    }
}
