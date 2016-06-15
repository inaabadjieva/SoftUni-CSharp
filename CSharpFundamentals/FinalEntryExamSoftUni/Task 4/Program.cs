using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split(' ');

                string command = data[0];
                if (command == "swap" || command == "multiply")
                {
                    int pos1 = int.Parse(data[1]);
                    int pos2 = int.Parse(data[2]);
                    long temp = array[pos1];
                    if (command == "swap")
                    {
                        temp = array[pos1];
                        array[pos1] = array[pos2];
                        array[pos2] = temp;
                    }
                    else if (command == "multiply")
                    {
                        array[pos1] = array[pos1] * array[pos2];
                    }
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i]--;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));

        }
    }
}
