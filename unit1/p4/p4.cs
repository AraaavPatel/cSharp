using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\n--- Relational Operators ---");
        Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
        Console.WriteLine($"{num1} != {num2}: {num1 != num2}");
        Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
        Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
        Console.WriteLine($"{num1} >= {num2}: {num1 >= num2}");
        Console.WriteLine($"{num1} <= {num2}: {num1 <= num2}");
    }
}