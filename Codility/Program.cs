using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(2032, "February", "February", "Wednesday");

            Console.WriteLine(result);
            Console.ReadLine();
        }

        //Y = year of vacation 2014
        //A = beginning month vacation april
        //B = ending month vacation may
        //W = day week 1st january that year wednesday
        //return 7
        public static int solution(int Y, string A, string B, string W)
        {
            var months = new Dictionary<string, int>() {
                { "January", 1 },
                { "February", 2 },
                { "March", 3 },
                { "April", 4 },
                { "May", 5 },
                { "June", 6 },
                { "July", 7 },
                { "August", 8 },
                { "September", 9 },
                { "October", 10 },
                { "November", 11 },
                { "December", 12 } };

            var beginningVacation = new DateTime(Y, months[A], 1);
            var endVacation = new DateTime(Y, months[B], 1).ToLastDay();

            if (beginningVacation > endVacation)
                endVacation = endVacation.AddYears(1);

            var allbeginningMondays = beginningVacation.GetAllDays("Monday");
            var allEndSundays = endVacation.GetAllDays("Sunday");

            var bestDepartDate = new DateTime(beginningVacation.Year, beginningVacation.Month, allbeginningMondays.First());
            var bestArriveDate = new DateTime(endVacation.Year, endVacation.Month, allEndSundays.Last());

            return bestArriveDate.WeeksApart(bestDepartDate);
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime ToLastDay(this DateTime date)
        {
            return date.AddMonths(1).AddDays(-1);
        }

        public static IEnumerable<int> GetAllDays(this DateTime date, string dayName)
        {
            var allDatesInMonth = date.AllDatesInMonth();

            DayOfWeek day;
            if (Enum.TryParse(dayName, out day))
            {
                return allDatesInMonth.Where(x => x.DayOfWeek == day).Select(x => x.Day).OrderBy(x => x);
            }

            return new List<int>();
        }

        public static int WeeksApart(this DateTime datetimeFrom, DateTime datetimeTo)
        {
            return Convert.ToInt32((datetimeFrom - datetimeTo).TotalDays / 7);
        }

        private static IEnumerable<DateTime> AllDatesInMonth(this DateTime date)
        {
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(date.Year, date.Month, day);
            }
        }
    }
}
