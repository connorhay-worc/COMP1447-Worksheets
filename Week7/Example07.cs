using System;

namespace Week7
{
    public class Example07
    {
        public static void A()
        {
            // COMP1447 Week 7 -- Example 07a
            // Checking Lagrange's Four Square Theorem
            // Every positive integer is the sum of four squares
            // https://en.wikipedia.org/wiki/Lagrange%27s_four-square_theorem
            Console.WriteLine("Checking Lagrange's Four Square Theorem");
            int number, current;
            int count = 0;
            // Attempt 1 (smallish number)
            number = 999;
            // Assigning 0 to number will provide the answer of zero
            // Assigning a negative integer to number will not run as 'a' will always be less than number
            
            for (int a=0; a<=number; a++)
            {
                for (int b=a; b<=number; b++)
                {
                    for (int c=b; c<=number; c++)
                    {
                        for (int d=c; d<=number; d++)
                        {
                            current = a*a + b*b + c*c + d*d;
                            count++;
                            if (current == number)
                            {
                                Console.Write("Found it: ");
                                Console.Write(number + " = " + a + "^2 + " + b + "^2");
                                Console.WriteLine(" + "+c + "^2 + " + d + "^2");
                                Console.WriteLine("Count: " + count);
                                count = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("[done]");
        }

        
        
        public static void B()
        {
            // COMP1447 Week 7 -- Example 07b
            
            // Checking Lagrange's Four Square Theorem
            // Every positive integer is the sum of four squares
            // https://en.wikipedia.org/wiki/Lagrange%27s_four-square_theorem
            
            Console.WriteLine("Checking Lagrange's Four Square Theorem");
            int number, current;
            int count = 0;
            // Attempt 2 (larger number)
            number = 99999;
            for (int a = 0; a <= Math.Sqrt(number); a++)
            for (int b = a; b <= Math.Sqrt(number-a*a); b++)
            for (int c = b; c <= Math.Sqrt(number-a*a-b*b); c++)
            for (int d = c; d <= Math.Sqrt(number-a*a-b*b-c*c); d++)
            {
                current = a * a + b * b + c * c + d * d;
                if (current == number)
                {
                    Console.Write("\nFound it: ");
                    Console.Write(number + " = " + a + "^2 + " + b + "^2");
                    Console.WriteLine(" + " + c + "^2 + " + d + "^2");
                }
                count++;
                if (count % 10000 == 0)
                    Console.Write(".");
            }
            Console.WriteLine("[done]");
        }
    }
}