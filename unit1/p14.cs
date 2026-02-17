using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        int number2 = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for (int i = number1; i <= number2; i++)
        {
            sum += i;
        }
        
        Console.WriteLine($"Sum of numbers from 1 to {number} is: {sum}");
    }
}