using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int start = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int end = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"\nPrime numbers between {start} and {end}:");
        
        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
    
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}