using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class daysOfWeek
    {
        public void findDaysOfWeek()
        {
            int d, m, x, y;
            string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter date");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());

            y = year - (14 - month) / 12;
            x = y + y / 4 - y / 100 + y / 400;
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + (31 * m) / 12) % 7;

            Console.WriteLine("Entered date is " + weekDays[d]);
        }
    }
}
