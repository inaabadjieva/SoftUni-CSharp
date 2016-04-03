using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvertor
{
    class CurrencyConvertor
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var incurrency = Console.ReadLine();
            var outcurrency = Console.ReadLine();
            var USDtoBGN = 1.79549;
            var EURtoBGN = 1.95583;
            var GBPtoBGN = 2.53405;
            var AmountInBGN = 0.00;
            var output = 0.00;

            if (incurrency == "USD")
            {
                AmountInBGN = amount * USDtoBGN;
            }
            else if (incurrency == "EUR")
            {
                AmountInBGN = amount*EURtoBGN;
            }
            else if (incurrency == "GBP")
            {
                AmountInBGN = amount * GBPtoBGN;
            }
            else 
            { 
                AmountInBGN = amount; 
            }


            if (outcurrency == "USD")
            {
                output = AmountInBGN / USDtoBGN;
            }
            else if (outcurrency == "EUR")
            {
                output = AmountInBGN / EURtoBGN;
            }
            else if (outcurrency == "GBP")
            {
                output = AmountInBGN / GBPtoBGN;
            }
            else
            {
                output = AmountInBGN;
            }

            Console.WriteLine(Math.Round(output,2));
        }
    }
}
