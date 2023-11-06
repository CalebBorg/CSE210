using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("purple", 10);
        Circle circle = new Circle("blue", 15);
        Rectangle rectangle = new Rectangle("red", 5, 10);

        List<Shape> shapes = new List<Shape>{square, circle, rectangle};

        foreach (Shape shape in shapes){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }   
}