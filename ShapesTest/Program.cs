using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello > Enter Value Below");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello > Enter Another Value Below");
            double width = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = new Triangle(23,7);
            Rectangle rectangle = new Rectangle(3, 7);
            Square square = new Square(23, 37);
            Cube cube = new Cube(23, 37);
            Console.WriteLine($"{ triangle.Area(height,width)}");
        }
    }
}
