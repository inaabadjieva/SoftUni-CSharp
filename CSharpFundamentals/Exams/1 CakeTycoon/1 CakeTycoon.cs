using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong cakesWanted = ulong.Parse(Console.ReadLine());
            double kilosPerCake = double.Parse(Console.ReadLine());
            uint kilosAvailable = uint.Parse(Console.ReadLine());
            uint truffelsAvailable = uint.Parse(Console.ReadLine());
            uint priceTruffel = uint.Parse(Console.ReadLine());

            ulong truffelCost = (ulong) truffelsAvailable * priceTruffel;
            double cakesPossible = Math.Floor(kilosAvailable / kilosPerCake);

            if (cakesPossible < cakesWanted)
            {
                double kilosNeeded = (cakesWanted * kilosPerCake) - kilosAvailable;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", cakesPossible, kilosNeeded);
            }
            else
            {
                Console.WriteLine("All products available, price of a cake: {0:f2}", (truffelCost / cakesWanted) * 1.25);
            }
            
                
           
                

        }
    }
}
