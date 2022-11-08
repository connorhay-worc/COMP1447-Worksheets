using System;

namespace Week7
{
    public class Example05
    {
        public static void A()
        {
            // COMP1447 Week 7 -- Example 05a
            
            // Bresenham's algorithm (draw a line segment on a raster display)
            // https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm
            // Line segments in the "first octant" only
            
            Console.WriteLine("Bresenham's Algorithm");
            int x0, y0, x1, y1;
            x0 = 0; y0 = 0;
            x1 = 7; y1 = 5; // Plot line between 0,0 and 7,5
            int dx = x1 - x0;
            int dy = y1 - y0;
            int D = 2 * dy - dx;
            int y = y0;
            int x = x0;
            while (x <= x1)
            {
                Console.WriteLine("plotPixel(" + x + "," + y + ")");
                if (D > 0)
                {
                    y = y + 1;
                    D = D - 2 * dx;
                }
                D = D + 2 * dy;
                x++;
            } 
        }
    }
}