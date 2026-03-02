using System;

class Program
{
    static void Main()
    {
        int num1 = 15;
        int num2 = 8;
        int num3 = 12;
        
        int minimum = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);
        
        Console.WriteLine($"Minimum of {0}, {1}, and {2} is: {3}", num1, num2, num3, minimum);
    }
}