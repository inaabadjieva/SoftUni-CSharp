using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var newdays = day + 5;

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (newdays > 30)
                {
                    month ++;
                    newdays = newdays - 30;
                }
            }
            else if (month == 2)
            {
                if (newdays > 28)
                {
                    month ++;
                    newdays = newdays - 28;
                }
            }
            else
            {
                if (newdays > 31)
                {
                    month ++;
                    newdays = newdays - 31;
                }
            }
            if (month > 12)
            {
                month = month - 12;
            }

            if (month < 10)
                Console.WriteLine(newdays + ".0" + month);
            else
                Console.WriteLine(newdays + "." + month);
        }
    }
}
