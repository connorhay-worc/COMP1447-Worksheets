
using System;

namespace Week7
{
    public class Example01a
    {
        public Example01a()
        {
            // COMP1447 Week 7 -- Example 01a
            int product;
            int counter;
            // Calculate 10! = 10*9*8*7*6*5*4*3*2*1 (called "10 factorial")
            Console.WriteLine("Calculate a factorial using a while loop [version 1]");
            product = 10;
            Console.WriteLine(" Calculating " + product + " factorial");
            counter = product - 1;
            Console.WriteLine(" Entering loop ...");
            while (counter>0)
            {
                Console.WriteLine(" inside the loop");
                Console.WriteLine( "counter=" + counter + " product=" + product);
                Console.WriteLine(" update product ...");
                product = product * counter;
                Console.WriteLine(" product=" + product);
                Console.WriteLine(" update counter ...");
                counter--;
                Console.WriteLine(" counter=" + counter);
                Console.WriteLine(" last line of loop [press any key to continue]");
                Console.ReadKey();
            }
            Console.WriteLine(" Conclusion: product=" + product);
            Console.WriteLine("[done]");
        }

        
    }
}