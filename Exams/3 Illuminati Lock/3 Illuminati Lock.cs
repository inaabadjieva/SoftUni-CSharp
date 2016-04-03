using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lenght = 3 * n;

            string sideStart = new string('.', n);
            string middleStart = new string('#', n);
            Console.WriteLine("{0}{1}{0}", sideStart, middleStart);

            for (int i = 1; i <= n/2; i++)
            {
                int edgePoint = n - 2 * i;
                int midPoint = n - 2;
                int sidePoint = (3*n - 2*edgePoint - midPoint - 6) / 2;
                string edge = new string('.', edgePoint);
                string mid = new string('.', midPoint);
                string side = new string('.', sidePoint);
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", edge,side,mid);
            }
            for (int i = n/2; i > 0; i--)
            {
                int edgePoint = n - 2 * i;
                int midPoint = n - 2;
                int sidePoint = (3*n - 2*edgePoint - midPoint - 6) / 2;
                string edge = new string('.', edgePoint);
                string mid = new string('.', midPoint);
                string side = new string('.', sidePoint);
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", edge,side,mid);
            }
            
            Console.WriteLine("{0}{1}{0}", sideStart, middleStart);
            
        }
    }
}
