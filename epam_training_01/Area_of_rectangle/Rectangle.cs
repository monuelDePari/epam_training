using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_rectangle
{
    class Rectangle //1-е завдання
    {
        double[,] coordinates = new double[2, 2];
        double area_of_rectangle_number, perymetr_of_rectangle_number;
        double width, length;
        public Rectangle() // Default conc
        {
            /*
            input_coordinates();
            side_length(coordinates[0, 0], coordinates[0, 1], coordinates[1, 0], coordinates[1, 1]);
            area_of_rectangle(length, width);
            perymetr_of_rectangle(length, width);
            */
        }
        public Rectangle(double n1, double n2, double n3, double n4) // conc with params
        {
            coordinates[0, 0] = n1;
            coordinates[0, 1] = n2;
            coordinates[1, 0] = n3;
            coordinates[1, 1] = n4;
            side_length(coordinates[0, 0], coordinates[0, 1], coordinates[1, 0], coordinates[1, 1]);
            area_of_rectangle(length, width);
            perymetr_of_rectangle(length, width);
        }
        public void input_coordinates()
        {
            try
            {
                Console.WriteLine("Type A and B coordinate postions in format number number1/ number2/ number1/ number2");
                string n = Console.ReadLine();
                string[] A = new string[4];
                A = n.Split("/ ");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (i < 1)
                            coordinates[i, j] = Convert.ToDouble(A[i + j]);
                        else
                            coordinates[i, j] = Convert.ToDouble(A[i + j + 1]);
                    }
                }
                Console.WriteLine(coordinates[0, 0] + " " + coordinates[0, 1] + " " + coordinates[1, 0] + " " + coordinates[1, 1] + " ");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void side_length(double n1, double n2, double n3, double n4)
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
        public void area_of_rectangle(double length, double width)
        {
            area_of_rectangle_number = length * width;
            Console.WriteLine("area of rectangle is: " + area_of_rectangle_number);
        }
        public void perymetr_of_rectangle(double length, double width)
        {
            perymetr_of_rectangle_number = (length + width) * 2;
            Console.WriteLine("Perymetr of rectangle is: " + perymetr_of_rectangle_number);
        }
    }
}
