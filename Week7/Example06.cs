using System;

namespace Week7
{
    public class Example06
    {
        public static void A()
        {
            // COMP1447 Week 7 -- Example 06a
            
            // Babylonian method to find a square root

            int count = 0;
            
            double target = 20.0; // want to find sqrt(target)
            double estimate = 1.0; // initial guess
            double error;
            do
            {
                count++;
                estimate = 0.5 * (target / estimate + estimate);
                error = Math.Abs(Math.Pow(estimate, 2) - target);
            } while (error > 0.00005); // Accuracy of estimation improves when the error condition is smaller

            Console.WriteLine("Final estimate for sqrt("+target+") is: " + estimate);
            Console.WriteLine("Actual: " + Math.Sqrt(target));
            Console.WriteLine("Count: " + count);
        }
    }
}