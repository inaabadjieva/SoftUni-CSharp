using System;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string ResultNumber = "";
            int b = -1;
            for (int a = 2; a < 1002; a++)
            {
                b = b * -1;
                ResultNumber = ResultNumber + (a * b);
                if (a < 1001)
                {
                    ResultNumber = ResultNumber + ",";
                }
            }
            Console.WriteLine(ResultNumber);
        }
    }
}