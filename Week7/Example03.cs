using System;

namespace Week7
{
    public class Example03
    {
        public static void A()
        {
            // COMP1447 Week 7 -- Example 03a
            
            // Area of a triangle with corner points (xA,yA), (xB,yB), (xC,yC)
            
            // https://www.mathopenref.com/coordtrianglearea.html
            
            double xA, yA, xB, yB, xC, yC;
            double area;
            // Anticlockwise order
            // xA = 0.0; yA = 0.0;
            // xB = 3.0; yB = 0.0;
            // xC = 3.0; yC = 7.0;
            
            // Clockwise order
            xA = 0.0; yA = 0.0;
            xB = 3.0; yB = 7.0;
            xC = 3.0; yC = 0.0;
            
            Console.Write("Triangle with corners ");
            Console.Write("(" + xA + "," + yA + "), ");
            Console.Write("(" + xB + "," + yB + "), ");
            Console.WriteLine("(" + xC + "," + yC + ")");
            area = 0.5 * ((xA - xC) * (yB - yA) - (xA - xB) * (yC - yA));
            Console.WriteLine(" area="+area);
            
            
            
        }
    }
}