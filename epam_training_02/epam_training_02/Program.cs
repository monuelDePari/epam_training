using System;

namespace epam_training_02
{
    interface IDrawable
    {
        void Draw();
    }
    internal class Figure : IDrawable
    {
        readonly double X, Y;
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Figure");
        }
    }
    class Square : Figure
    {
        public Square(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    class Program
    {
        public static void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            }
        }
        static void Main(string[] args)
        {
            IDrawable[] drawable = new IDrawable[3];
            Figure figure = new Figure(2, 1);
            drawable[0] = figure;
            //figure.Draw();
            Figure rectangle = new Rectangle(1.2, 1);
            drawable[1] = rectangle;
            //rectangle.Draw();
            Figure square = new Square(3.2, 2);
            drawable[2] = square;
            DrawAll(drawable);
            //square.Draw();
            //Rectangle rectangle = new Rectangle(1.2, 1);
            //Square square = new Square(3.2, 2);
            Console.ReadKey();
            


            //Output: 
            //Figure
            //Rectangle
            //Square
        }
    }
}
