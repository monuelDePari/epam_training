using System;
using System.Collections.Generic;
using System.Text;

namespace Area_of_rectangle // 2-е завдання
{
    class property_area_of_rectangle
    {
        private double[,] coordinates = new double[2, 2];
        double area_of_rectangle_number, perymetr_of_rectangle_number;
        double width, length;
        string n;
        public string Coordinates
        {
            get { return n; }
            set
            {
                try
                {
                    n = value;
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
                    length = coordinates[0, 0] - coordinates[1, 0];
                    if (length < 0)
                    {
                        length *= -1;
                    }
                    width = coordinates[0, 1] - coordinates[1, 1];
                    if (width < 0)
                    {
                        width *= -1;
                    }
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double Side_Length
        {
            get
            {
                perymetr_of_rectangle_number = length * width;
                return perymetr_of_rectangle_number;
            }
        }
        public double area_length
        {
            get
            {
                area_of_rectangle_number = length * width;
                return area_of_rectangle_number;
            }
        }

    }
}
