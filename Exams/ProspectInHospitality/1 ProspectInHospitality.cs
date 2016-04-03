using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            decimal buildersSalary = 1500.04m;
            decimal receptionistsSalary = 2102.10m;
            decimal chambermaidsSalary = 1465.46m;
            decimal techniciansSalary = 2053.33m;
            decimal othersSalary = 3010.98m;

            uint builders = uint.Parse(Console.ReadLine());
            buildersSalary *= builders;
            uint receptionists = uint.Parse(Console.ReadLine());
            receptionistsSalary *= receptionists;
            uint chambermaids = uint.Parse(Console.ReadLine());
            chambermaidsSalary *= chambermaids;
            uint technicians = uint.Parse(Console.ReadLine());
            techniciansSalary *= technicians;
            uint others = uint.Parse(Console.ReadLine());
            othersSalary *= others;

            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal USCurrency = decimal.Parse(Console.ReadLine());
            nikiSalary *= USCurrency;
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal allSalaries = buildersSalary + receptionistsSalary + chambermaidsSalary + techniciansSalary + othersSalary + nikiSalary + mySalary;
           
            Console.WriteLine("The amount is: {0:f2} lv.", allSalaries);

            if (budget >= allSalaries) Console.WriteLine("YES \\ Left: {0:f2} lv.", Math.Abs(budget-allSalaries));
            else Console.WriteLine("NO \\ Need more: {0:f2} lv.", Math.Abs(allSalaries-budget));
        }
    }
}
