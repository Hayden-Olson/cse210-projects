using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Blue", 20));
        shapes.Add(new Rectangle("Red", 12, 13));
        shapes.Add(new Circle("Purple", 12));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.\n");
        }
    }
}