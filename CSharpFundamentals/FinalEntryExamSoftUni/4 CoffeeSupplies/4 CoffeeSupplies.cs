using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = Console.ReadLine().Split(' ').ToArray();

            var personCoffee = new Dictionary<string, string>();
            var coffeeQuantity = new Dictionary<string, int>();

            var info = new List<string>();

            string input = Console.ReadLine();
            while (input != "end of info")
            {
                if (input.Contains(separators[0]))
                {
                    info = input.Split(new string[] { separators[0] }, StringSplitOptions.None).ToList();
                    personCoffee.Add(info[0].ToString(), info[1].ToString());
                }
                else if (input.Contains(separators[1]))
                {
                    info = input.Split(new string[] { separators[1] }, StringSplitOptions.None).ToList();
                    if (coffeeQuantity.ContainsKey(info[0].ToString()))
                        coffeeQuantity[info[0].ToString()] += int.Parse(info[1]);
                    else
                        coffeeQuantity.Add(info[0].ToString(), int.Parse(info[1]));
                }

                info.Clear();
                input = Console.ReadLine();
            }
            foreach (var pair in coffeeQuantity)
            {
                if (pair.Value <= 0)
                    Console.WriteLine("Out of {0}", pair.Key);
            }
            foreach (var value in personCoffee.Values)
            {
                if (!coffeeQuantity.ContainsKey(value))
                    Console.WriteLine("Out of {0}", value);
            }

            var coffeeType = "";
            var quantity = 0;
            var left = 0;
            var coffeeDrinked = new Dictionary<string, int>();
            var nameCoffeeLeft = new Dictionary<string, string>();

            input = Console.ReadLine();
            while (input != "end of week")
            {
                info = input.Split(' ').ToList();
                personCoffee.TryGetValue(info[0], out coffeeType);
                coffeeQuantity.TryGetValue(coffeeType, out quantity);
                left = quantity - int.Parse(info[1]);
                coffeeQuantity[coffeeType] = left;
                if (left <= 0)
                {
                    Console.WriteLine("Out of {0}", coffeeType);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left: ");


            var result = coffeeQuantity.OrderByDescending(x => x.Value);
            foreach (var pair in result)
            {
                if (pair.Value > 0)
                {
                    Console.WriteLine("{0} {1}", pair.Key, pair.Value);
                }
            }

            Console.WriteLine("For:");

            var cafes = coffeeQuantity.OrderBy(x => x.Key);
            var names = personCoffee.OrderByDescending(x => x.Key);
            foreach (var pair in cafes)
            {
                foreach (var p in names)
                {
                    if (pair.Key == p.Value && pair.Value > 0)
                    {
                        Console.WriteLine("{0} {1}", p.Key, p.Value);
                    }
                }
            }
        }
    }
}
