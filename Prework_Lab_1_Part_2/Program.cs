using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_Lab_1_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for first date in year-month-day
           Console.WriteLine("Input the first date in the format of year-month-day, (yyyy-MM-dd): ");
            string input1 =Console.ReadLine();

            //turns input into the date form
            DateTime  dt1 = DateTime.ParseExact(input1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

         
            //asks for a second date from user
            Console.WriteLine("Input the second date in the format of year-month-day, (yyyy-MM-dd): ");
            string input2 = Console.ReadLine();

            //turns into datetime form
            DateTime dt2 = DateTime.ParseExact(input2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

          
            //sets a variable for timespan and subtracts the two dates
            TimeSpan timespan = dt1.Subtract(dt2);

            //makes sure that the days returned are not negative.
            if (timespan.TotalDays < 0)
            {
                Console.WriteLine("The difference in number of days: {0}, number of hours: {1}, and number of minutes: {2}."
                                , timespan.TotalDays * -1, timespan.TotalDays*24*-1, timespan.TotalDays*24*60*-1);
            }
            else
            {

                Console.WriteLine("The difference in number of days: {0}, number of hours: {1}, and number of minutes: {2}."
                                , timespan.TotalDays, timespan.TotalDays * 24, timespan.TotalDays * 24 * 60);
            }

            Console.ReadLine();
        }
    }
}
