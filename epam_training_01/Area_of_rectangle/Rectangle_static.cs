using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_rectangle
{
    static class Rectangle_static
    {
        private static double[,] coordinates = new double[2, 2];
        static double area_of_rectangle_number, perymetr_of_rectangle_number;
        static double width, length;
        public static void SetCoordinates(double n1, double n2, double n3, double n4)
        {
            coordinates[0, 0] = n1;
            coordinates[0, 1] = n2;
            coordinates[1, 0] = n3;
            coordinates[1, 1] = n4;
            side_length(n1, n2, n3, n4);
        }
        static void side_length(double n1, double n2, double n3, double n4)
        {
            length = n1 - n3;
            if (length < 0)
            {
                length *= -1;
            }
            width = n2 - n4;
            if (width < 0)
            {
                width *= -1;
            }
        }
        public static void area_of_rectangle()
        {
            area_of_rectangle_number = length * width;
            Console.WriteLine("area of rectangle is: " + area_of_rectangle_number);
        }
        public static void perymetr_of_rectangle()
        {
            perymetr_of_rectangle_number = (length + width) * 2;
            Console.WriteLine("Perymetr of rectangle is: " + perymetr_of_rectangle_number);
        }
    }
}
