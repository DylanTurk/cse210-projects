using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        Square square = new Square("Red", 5.0);

        Rectangle rectangle = new Rectangle("Blue", 3.0, 4.0);

        Circle circle = new Circle("Green", 2.0);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("\nIterating through shapes in the list...");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} - Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
