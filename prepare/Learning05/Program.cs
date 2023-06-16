using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();
        
        Square sqr = new Square("Green", 5);
        Shapes.Add(sqr);

        Rectangle rect = new Rectangle("Red", 20, 5);
        Shapes.Add(rect);

        Circle cir = new Circle("Blue", 10);
        Shapes.Add(cir);

        foreach (Shape shp in Shapes)
        {
            string color = shp.GetColor();
            double area = shp.GetArea();

            Console.WriteLine($"The area of the {color} shape is {area}");
        }
    }
}