using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LocalElections
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidates = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine().ToLower();

            Console.WriteLine(new string('.', 13));

            for (int i = 1; i <= candidates; i++)
            {
                Console.WriteLine("...+{0}+...", new string('-', 5));
                if (i == vote)
                {
                    if (symbol == "x")
                    {
                        Console.WriteLine("...|.\\./.|...", new string('.', 5));
                        Console.WriteLine("{0}.|..X..|...", i.ToString().PadLeft(2, '0'));
                        Console.WriteLine("...|./.\\.|...", new string('.', 5));
                    }
                    else if (symbol=="v")
                    {
                        Console.WriteLine("...|\\.../|...", new string('.', 5));
                        Console.WriteLine("{0}.|.\\./.|...", i.ToString().PadLeft(2, '0'));
                        Console.WriteLine("...|..V..|...", new string('.', 5));   
                    }
                }
                else
                {
                    Console.WriteLine("...|{0}|...", new string('.', 5));
                    Console.WriteLine("{0}.|.....|...", i.ToString().PadLeft(2,'0'));
                    Console.WriteLine("...|{0}|...", new string('.', 5));   
                }
                Console.WriteLine("...+{0}+...", new string('-', 5));
                Console.WriteLine(new string('.', 13));
            }
        }
    }
}
