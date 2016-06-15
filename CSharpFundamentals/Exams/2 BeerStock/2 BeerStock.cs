using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BeerStock
{
    class Program
    {
        static void Main(string[] args)
        {
            uint reservedAmount = uint.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            long beersCount = 0;
            while (line != "Exam Over")
            {
                string[] parameters = line.Split();
                long amount = long.Parse(parameters[0]);
                string type = parameters[1];
                switch (type)
                {
                    case "cases":
                        beersCount += amount * 24;
                        break;
                    case "sixpacks":
                        beersCount += amount * 6;
                        break;
                    default:
                        beersCount += amount;
                        break;
                }

                line = Console.ReadLine();
            }
            beersCount = beersCount - beersCount / 100;
            if (beersCount >= reservedAmount)
            {
                long beersLeft = beersCount - reservedAmount;
                long cases = beersLeft / 24;
                beersLeft %= 24;
                long sixpacks = beersLeft / 6;
                beersLeft %= 6;
               
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases,sixpacks,beersLeft);
            }
            else
            {
                long beersLeft = reservedAmount - beersCount;
                long cases = beersLeft / 24;
                beersLeft %= 24;
                long sixpacks = beersLeft / 6;
                beersLeft %= 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beersLeft);
            }

        }
    }
}
