using System;

class SummerHammer
{
    static void Main()
    {
        var budget = decimal.Parse(Console.ReadLine());
        var people = int.Parse(Console.ReadLine());
        var vodka = decimal.Parse(Console.ReadLine());
        var menta = decimal.Parse(Console.ReadLine());
        var soda = decimal.Parse(Console.ReadLine());
        var absent = decimal.Parse(Console.ReadLine());

        var totalVodka = people * 100;
        var totalMenta = people * 50;
        var totalSoda = people * 25;
        var totalAbsent = people * 25;

        var bottlesVodka = 0;
        if (totalVodka / 1000 == 0)
        {
            bottlesVodka = totalVodka / 1000;
        }
        else
        {
            bottlesVodka = totalVodka / 1000 + 1;
        }
        var bottlesMenta = 0;
        if (totalMenta / 1000 == 0)
        {
            bottlesMenta = totalMenta / 1000;
        }
        else
        {
            bottlesMenta = totalMenta / 1000 + 1;
        }
        var bottlesSoda = 0;
        if (totalSoda / 1000 == 0)
        {
            bottlesSoda = totalSoda / 1000;
        }
        else
        {
            bottlesSoda = totalSoda / 1000 + 1;
        }
        var bottlesAbsent = 0;
        if (totalAbsent / 700 == 0)
        {
            bottlesAbsent = totalAbsent / 1000;
        }
        else
        {
            bottlesAbsent = totalAbsent / 1000 + 1;
        }
        var total = bottlesVodka * vodka + bottlesMenta * menta + bottlesSoda * soda + bottlesMenta * absent;
        if (total < budget)
        {
            Console.WriteLine("Let's the party starts now!");
        }
        else
        {
            Console.WriteLine("Not enough money for the party! Pesho needs {0:f2} lv.", total - budget);
        }
    }
}

