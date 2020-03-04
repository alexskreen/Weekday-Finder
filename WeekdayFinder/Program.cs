using System;

namespace WeekdayFinder.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input a month with two digits: Ex: 01 = January, 02 = February, etc.");
            int result = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a day with two digits: ");
            int result2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a year with four digits: ");
            int result3 = int.Parse(Console.ReadLine());
            DateTime dateValue = new DateTime(result3, result, result2);
            Console.WriteLine("-------------------");
            Console.WriteLine(dateValue.ToString("dddddddd"));
        }
    }
}