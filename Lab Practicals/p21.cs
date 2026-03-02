using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        int minimum = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] < minimum)
                minimum = numbers[i];
        }
        
        Console.WriteLine($"Minimum number: {minimum}");
    }
}