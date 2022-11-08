using System;

namespace Week7
{
    public class Example04
    {
        public static void A()
        {
            // COMP1447 Week 7 -- Example 04a
            
            // Leap year
            bool leapYear;
            
            // Attempt 1 (wrong expression)
            Console.WriteLine("Attempt 1");
            for (int year = 1995; year<=2020; year++)
            {
                leapYear = ((year % 4 == 0) && (year % 100 == 0)) || (year % 400 == 0);
                Console.WriteLine("year=" + year + " leapYear=" + leapYear);
            }
            
            // Attempt 2 (looking closer at the terms)
            Console.WriteLine("Attempt 2");
            for (int year = 1995; year <= 2020; year++)
            {
                bool firstPart = (year % 4 == 0);
                bool secondPart = (year % 100 == 0);
                bool thirdPart = (year % 400 == 0);
                Console.Write("year=" + year + " mod4=" + firstPart);
                Console.WriteLine(" mod100=" + secondPart + " mod400=" + thirdPart);
            } 
            
            // My Attempt
            Console.WriteLine("Attempt 3 (My Attempt)");
            for (int year = 1800; year <= 2600; year++)
            {
                leapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
                
                Console.WriteLine("year=" + year + " leapYear=" + leapYear);
            }
        }
    }
}