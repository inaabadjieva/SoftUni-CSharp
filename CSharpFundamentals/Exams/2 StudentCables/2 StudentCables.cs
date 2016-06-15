using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_StudentCables
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint totalCable = 0;
            uint join = 0;
            for (int i = 0; i < n; i++)
            {
                uint cableSize = uint.Parse(Console.ReadLine());
                string size = Console.ReadLine();
                if (size == "meters") cableSize = cableSize * 100;
                if (cableSize >= 20)
                {
                    totalCable += cableSize;
                    join++;
                }
            }
            totalCable = totalCable - 3*(join-1);
            uint studentCables = totalCable / 504;
            uint remainingCable = totalCable % 504;
            Console.WriteLine(studentCables);
            Console.WriteLine(remainingCable);


        }
    }
}
