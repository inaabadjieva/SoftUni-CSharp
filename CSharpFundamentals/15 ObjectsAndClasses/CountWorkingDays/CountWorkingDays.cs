using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);           
            DateTime endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int businessDays = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if(date.DayOfWeek != DayOfWeek.Saturday &&
                    date.DayOfWeek != DayOfWeek.Sunday &&
                    !OfficialHolidays(date))
                {
                    businessDays++;
                }
            }

            Console.WriteLine(businessDays);
        }

        private static bool OfficialHolidays(DateTime date)
        {
            var officialHolidays = new List<DateTime>()
            {
                new DateTime(date.Year, 01, 01),
                new DateTime(date.Year, 03, 03),
                new DateTime(date.Year, 05, 01),
                new DateTime(date.Year, 05, 06),
                new DateTime(date.Year, 05, 24),
                new DateTime(date.Year, 09, 06),
                new DateTime(date.Year, 09, 22),
                new DateTime(date.Year, 10, 01),
                new DateTime(date.Year, 12, 24),
                new DateTime(date.Year, 12, 25),
                new DateTime(date.Year, 12, 26),
            };
            if (officialHolidays.Contains(date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
