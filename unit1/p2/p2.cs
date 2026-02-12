using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("\n--- Arithmetic Operations ---");
        Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
        
        if (num2 != 0)
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
        else
            Console.WriteLine("Division: Cannot divide by zero");
            
        Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");
    }
}