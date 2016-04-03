using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var inmetric = (Console.ReadLine());
            var outmetric = (Console.ReadLine());
           
            var firstrate = 0.00;
            var secondrate = 0.00;  
            
            if (inmetric == "m")
            {
                firstrate = 1;
            }
            else if (inmetric == "mm")
            {
                firstrate = 1000;
            }
            else if (inmetric == "cm")
            {
                firstrate = 100;
            }
            else if (inmetric == "mi")
            {
                firstrate = 0.000621371192;
            }
            else if (inmetric == "in")
            {
                firstrate = 39.3700787;
            }
            else if (inmetric == "km")
            {
                firstrate = 00.001;
            }
            else if (inmetric == "ft")
            {
                firstrate = 3.2808399;
            }
            else if (inmetric == "yd")
            {
                firstrate = 1.0936133;
            }


            if (outmetric == "m")
            {
                secondrate = 1;
            }
            else if (outmetric == "mm")
            {
                secondrate = 1000;
            }
            else if (outmetric == "cm")
            {
                secondrate = 100;
            }
            else if (outmetric == "mi")
            {
                secondrate = 0.000621371192;
            }
            else if (outmetric == "in")
            {
                secondrate = 39.3700787;
            }
            else if (outmetric == "km")
            {
                secondrate = 00.001;
            }
            else if (outmetric == "ft")
            {
                secondrate = 3.2808399;
            }
            else if (outmetric == "yd")
            {
                secondrate = 1.0936133;
            }
            var result = amount * (secondrate / firstrate);
            Console.WriteLine("{0} {1}", result, outmetric);
        }
    }
}
