using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1000Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", null);
            DateTime result = birthday.AddDays(999);
            Console.WriteLine(result.ToString("dd-MM-yyyy"));
        }
    }
}
