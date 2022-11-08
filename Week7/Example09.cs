using System;

namespace Week7
{
    public class Example09
    {
        public static void A()
        {
            // COMP1447 Week 7 -- Example 09
            try
            { 
                int a = 1 / 2;
                int b = 2 / a;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Noticed that there was a divide by zero exception");
            }
            Console.WriteLine("Carrying on ...");
        }
    }
}