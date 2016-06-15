using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal overallProfit = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int adults = int.Parse(Console.ReadLine());
                decimal adultsTicket = decimal.Parse(Console.ReadLine());
                int youths = int.Parse(Console.ReadLine());
                decimal youthsTicket = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPerHour = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                var income = adults * adultsTicket + youths * youthsTicket;
                var expenses = fuelPrice * fuelPerHour * flightDuration;
                var profit = income - expenses;
                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:f3}$.", profit);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", profit);
                }

                overallProfit += profit;
                count++;
            }
            Console.WriteLine("Overall profit -> {0:f3}$.", overallProfit);
            Console.WriteLine("Average profit -> {0:f3}$.", overallProfit/count);
        }
    }
}
