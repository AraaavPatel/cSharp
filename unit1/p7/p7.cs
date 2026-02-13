using System;

class AOC
{
    static void Main()
    {
        double r, a;

        Console.WriteLine("Enter Radius of circle");
        r = float.Parse(Console.ReadLine());

        a = 3.14 * r * r;

        Console.WriteLine("Area of circle is :"+a);
    }

}