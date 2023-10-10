using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square();
        square.SetColor("Blue");
        square.SetSide(3);
        //square.DisplayShapeInfo();

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Red");
        rectangle.SetHeight(3);
        rectangle.SetLength(8);
        //rectangle.DisplayShapeInfo();

        Circle circle = new Circle();
        circle.SetColor("Green");
        circle.SetRadius(8);
        //circle.DisplayShapeInfo();

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"{s.GetColor()} - {s._GetArea()}");
        }
    }
}