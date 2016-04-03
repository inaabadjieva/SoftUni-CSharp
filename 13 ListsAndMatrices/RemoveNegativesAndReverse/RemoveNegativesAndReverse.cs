using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positives = new List<int>();
            foreach (var item in list)
            {
                if (item >= 0) positives.Add(item);
            }
            positives.Reverse(); 
            if (positives.Count>0)
                Console.WriteLine(string.Join(" ", positives));
            else
                Console.WriteLine("empty");
        }
    }
}
