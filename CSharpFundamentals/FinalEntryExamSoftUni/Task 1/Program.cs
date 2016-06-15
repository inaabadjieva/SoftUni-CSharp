using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesKilo = decimal.Parse(Console.ReadLine());

            int setOfPortions = guests / 6;
            if (guests % 6 != 0) setOfPortions += 1;

            bananasPrice *= 2;
            eggsPrice *= 4;
            berriesKilo *= 0.2M;
            decimal productsCost = setOfPortions * bananasPrice + setOfPortions * eggsPrice + setOfPortions * berriesKilo;

            if(productsCost <= cash)
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", productsCost);
            else
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", productsCost-cash);
        }
    }
}
