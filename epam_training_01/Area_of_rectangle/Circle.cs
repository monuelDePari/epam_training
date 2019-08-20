using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_rectangle
{
    class Circle
    {
        private double Radius, area, length;
        private const double pi = 3.14;
        public Circle(double Radius)
        {
            this.Radius = Radius;
            Circle_length(Radius);
            Circle_area(Radius);
        }
        public void Circle_length(double Radius)
        {
            length = 2 * pi * Radius;
        }
        public void Circle_area(double Radius)
        {
            area = pi * (Radius * Radius);
        }
        public void get_info()
        {
            if(Radius != 0)
            {
                Console.WriteLine("Radius is: " + Radius + " Length is: " + length + " area is: " + area);
            }
        }
    }
}
