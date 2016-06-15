using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
         
        public static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ');
            var town = input[0];
            var product = input[1];
            var price = decimal.Parse(input[2]);
            var quantity = decimal.Parse(input[3]);
            var sale = new Sale() { Town = town, Product = product, Price = price, Quantity = quantity };
            return sale;
        }

    }
    class SalesReport
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var sale = Sale.ReadSale();
                sales.Add(sale);
            }
            var towns = new SortedSet<string>();
            var sums = new SortedDictionary<string, decimal>();
            foreach (var s in sales)
            {
                towns.Add(s.Town);
                sums[s.Town] = 0;
            }
            foreach (var s in sales)
            {
                sums[s.Town] += s.Price * s.Quantity;
            }
            foreach (var t in towns)
            {
                Console.WriteLine("{0} -> {1:f2}", t, sums[t]);
            }
            //var towns = sales.Select(s => s.Town).OrderBy(t => t).Distinct().ToList();
            //foreach (var town in towns)
            //{
            //    var salesForTown = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
            //    Console.WriteLine("{0} -> {1:f2}", town, salesForTown);
            //}
        }
    }
}
