using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

            Circle c1 = new Circle("Blue", 3);
            shapes.Add(c1);

            Rectangle r1 = new Rectangle("Green", 4, 5);
            shapes.Add(r1);

            Square s1 = new Square("Yellow", 6);
            shapes.Add(s1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}