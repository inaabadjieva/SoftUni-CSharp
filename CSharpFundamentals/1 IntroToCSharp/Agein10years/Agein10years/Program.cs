using System;

namespace AgeAfterTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Birthdate:");
            DateTime Birthdate = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = DateTime.Now.Subtract(Birthdate);
            Console.WriteLine(difference.Days / 365);
            int AgeNow = difference.Days / 365;
            Console.WriteLine("After 10 years you will be at age of " + (AgeNow + 10));
            
           
        }
    }
}
