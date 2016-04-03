using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterMusicProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            int albumsEurope = int.Parse(Console.ReadLine());
            decimal priceEuro = decimal.Parse(Console.ReadLine())*1.94m;
            int albumsNorthAm = int.Parse(Console.ReadLine());
            decimal priceDollars = decimal.Parse(Console.ReadLine())*1.72m;
            int albumsSouthAm = int.Parse(Console.ReadLine());
            decimal pricePesos = decimal.Parse(Console.ReadLine())/332.74m;
            int concerts = int.Parse(Console.ReadLine());
            decimal profitPerConcert = decimal.Parse(Console.ReadLine())*1.94m;

            decimal profitOne = albumsEurope * priceEuro + albumsNorthAm * priceDollars + albumsSouthAm * pricePesos;
            profitOne -= 0.35m * profitOne;
            profitOne -= 0.2m * profitOne;

            decimal profitTwo = concerts * profitPerConcert;
            if (profitTwo >= 100000) profitTwo -= 0.15m * profitTwo;

            if (profitOne > profitTwo)
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", profitOne);
            else
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", profitTwo);

        }  
    }
}
