using System;

namespace Area_of_rectangle
{  
    class Program
    {
        private double[,] coordinates = new double[2, 2];
        double Radius;
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
        void Radius_input()
        {
            try
            {
                Console.WriteLine("Type Radius of Circle!");
                Radius = Convert.ToDouble(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.input_coordinates();
            Rectangle rectangle = new Rectangle(program.coordinates[0, 0], program.coordinates[0, 1], program.coordinates[1, 0], program.coordinates[1, 1]);
            Console.ReadKey();
            property_area_of_rectangle area = new property_area_of_rectangle();
            Console.WriteLine("Type A and B coordinate postions in format number number1/ number2/ number1/ number2");
            try
            {
                string n = Console.ReadLine();
                area.Coordinates = n;
                Console.WriteLine("Perym of rectangle is: " + area.Side_Length + " Area of rectangle is: " + area.area_length);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            program.Radius_input();
            Circle circle = new Circle(program.Radius);
            circle.get_info();
            program.input_coordinates();
            Rectangle_static.SetCoordinates(program.coordinates[0, 0], program.coordinates[0, 1], program.coordinates[1, 0], program.coordinates[1, 1]);
            Rectangle_static.area_of_rectangle();
            Rectangle_static.perymetr_of_rectangle();
            program.Radius_input();
            Circle_static.SetRadius(program.Radius);
            Circle_static.Circle_area();
            Circle_static.Circle_length();
            Circle_static.get_info();
            ComplexNumber complex = new ComplexNumber();
            Console.WriteLine("Type real part of first complex number!");
            complex.Real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type imaginary part of first complex number!");
            complex.Imaginary = Convert.ToDouble(Console.ReadLine());
            ComplexNumber complex_01 = new ComplexNumber();
            Console.WriteLine("Type real part of second complex number!");
            complex_01.Real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type imaginary part of second complex number!");
            complex_01.Imaginary = Convert.ToDouble(Console.ReadLine());
            ComplexNumber complex_02 = complex * complex_01;
            complex_02.output(complex_02);
            complex_02 = new ComplexNumber();
            complex_02 = complex / complex_01;
            complex_02.output(complex_02);
            Console.ReadKey();
            //property_area_of_rectangle rectangle1 = new property_area_of_rectangle();
            //rectangle1.Coordinates = "-2/ 2/ 3/ 1";
            //Console.WriteLine("Perym of rectangle is: " + rectangle1.Side_Length + " Area of rectangle is: " + rectangle1.area_length);
            //Circle circle = new Circle(6.1);
            //circle.get_info();
            //Rectangle_static.SetCoordinates(-2, -2, 2, 2);
            //Rectangle_static.area_of_rectangle();
            //Rectangle_static.perymetr_of_rectangle();
            //Circle_static.SetRadius(3);
            //Circle_static.Circle_area();
            //Circle_static.Circle_length();
            //Circle_static.get_info();
            //ComplexNumber complex = new ComplexNumber(3, 1);
            //ComplexNumber complex_01 = new ComplexNumber(2, -2);
            //ComplexNumber complex_02 = complex * complex_01;
            //ComplexNumber complex_02 = new ComplexNumber();
            //complex_02 = complex / complex_01;
            //complex_02.output(complex_02);
            //Console.Read();
        }
    }
}
