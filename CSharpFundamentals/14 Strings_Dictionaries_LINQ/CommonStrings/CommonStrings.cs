using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonStrings
{
    class CommonStrings
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().ToCharArray();
            var second = Console.ReadLine().ToCharArray();

            bool yes = false;
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        yes = true;
                        break;
                    }
                }
            }
            if (yes) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
