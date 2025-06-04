using System;
namespace GeometricShapes
{
    class BaseGeometricShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public virtual double CalculateArea()
        {
            return Width * Height;
        }
    }
    class Square:BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    class Rectangle : BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    class RightTriangle : BaseGeometricShape
    {
        public override double CalculateArea()
        {
            return (Width * Height) / 2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Width = 5;
            square.Height = 5;
            Console.WriteLine($"Karenin alanı: {square.CalculateArea()}");
            
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 4;
            rectangle.Height = 6;
            Console.WriteLine($"Dikdörtgenin alanı: {rectangle.CalculateArea()}");

            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.Width = 3;
            rightTriangle.Height = 8;
            Console.WriteLine($"Dik üçgenin alanı: {rightTriangle.CalculateArea()}");

            Console.ReadLine();




        }


    }


}