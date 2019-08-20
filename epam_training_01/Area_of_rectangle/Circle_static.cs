using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_rectangle
{
    static class Circle_static
    {
        private static double Radius, area, length;
        private const double pi = 3.14;
        public static void SetRadius(double Radius1)
        {
            Radius = Radius1;
        }
        public static void Circle_length()
        {
            length = 2 * pi * Radius;
        }
        public static void Circle_area()
        {
            area = pi * (Radius * Radius);
        }
        public static void get_info()
        {
            if (Radius != 0)
            {
                Console.WriteLine("Radius is: " + Radius + " Length is: " + length + " area is: " + area);
            }
        }
    }
}
