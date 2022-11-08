using System;

namespace Week7
{
    public class Example02
    {
        public Example02()
        {
            // COMP1447 Week 7 -- Example 02a
            
            // Swapping values of two variables
            
            int a, b;
            int c;
            Console.WriteLine("Two variables swap values [version 1]");
            a = 3;
            b = 5;
            Console.WriteLine("Start: a=" + a + ", b=" + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("End: a=" + a + ", b=" + b);
        }

        public static void Challenge()
        {
            // COMP1447 Week 7 -- Example 02c
            
            // Swapping values of two variables
            
            int a, b;
            Console.WriteLine("Two variables swap values [version 3]");
            a = 3;
            b = 5;
            Console.WriteLine("Start: a=" + a + ", b=" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("End: a=" + a + ", b=" + b);
        }
    }
}