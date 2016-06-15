using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string inmetric = (Console.ReadLine());
            string outmetric = (Console.ReadLine());

            var metrics = new Dictionary<string,decimal>()
            {
                {"m", 1},                
                {"mm", 1000},                
                {"cm", 100},                
                {"mi", 0.000621371192m},                
                {"in", 39.3700787m},                
                {"km", 0.001m},                
                {"ft", 3.2808399m},                
                {"yd", 1.0936133m}                                      	 
            }; 
            decimal result = amount*(metrics[outmetric]/metrics[inmetric]);
            Console.WriteLine("{0} {1}", result, outmetric);
        }
    }
}
