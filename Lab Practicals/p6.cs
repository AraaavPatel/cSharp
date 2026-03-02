using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Find Radius of a Circle");
        Console.WriteLine("=======================");
        
        Console.Write("Enter the area of the circle: ");
        double area = double.Parse(Console.ReadLine());
        
        // Formula: radius = sqrt(area / π)
        double radius = Math.Sqrt(area / Math.PI);
        
        Console.WriteLine($"Radius of the circle: {radius:F2}");
    }
}