using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGarfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine())/rate;
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine())/rate;
            decimal sandwichPrice = decimal.Parse(Console.ReadLine())/rate;
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal sum = (pizzaPrice*pizzaQuantity + lasagnaPrice*lasagnaQuantity + sandwichPrice*sandwichQuantity);
            if (money - sum >= 0)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", (money - sum));
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", Math.Abs(money - sum));

            }
        }
    }
}
