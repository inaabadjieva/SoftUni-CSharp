using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            object concatenated = a + ' ' + b;

            string result = concatenated.ToString();

            Console.WriteLine(result);
        }
    }
}
