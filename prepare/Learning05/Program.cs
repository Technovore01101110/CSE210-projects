using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Shape square = new Square(3, "Red");
        Shape rectangle = new Rectangle(4, 6, "Orange");
        Shape circle = new Circle(8, "Blue");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}, Area: {area}");
        }
    }
}