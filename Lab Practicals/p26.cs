using System;

class Rectangle
{
    
    private double length;
    private double width;

    public Rectangle()
    {
        length = 0;
        width = 0;
    }    
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    public double CalculateArea()
    {
        return length * width;
    }
    public void DisplayValues()
    {
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Area: {CalculateArea()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle();
        Console.WriteLine("Rectangle 1 (Default Constructor):");
        rect1.DisplayValues();
        Console.WriteLine();

        Rectangle rect2 = new Rectangle(5.5, 3.2);
        Console.WriteLine("Rectangle 2 (Parameterized Constructor):");
        rect2.DisplayValues();
        Console.WriteLine();

        Rectangle rect3 = new Rectangle(10, 7);
        Console.WriteLine("Rectangle 3:");
        rect3.DisplayValues();
    }
}
