using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultNumber = "";
            int b=-1;
            for (int a = 2; a <= 11; a++)
            {
                b = b * -1;
                resultNumber = resultNumber + (a * b);
                if (a<11)
                { resultNumber = resultNumber + ",";
                }
            }
            Console.WriteLine(resultNumber);
            
        }
    }        
}
