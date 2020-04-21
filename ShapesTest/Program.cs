using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangle triangle = new Triangle(203,137);
            Console.WriteLine($"{ triangle.Area()}");
        }
    }
}
