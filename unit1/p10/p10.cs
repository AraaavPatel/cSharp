using System;

class Factorial
{
    
    static long CalculateFactorial(int num)
    {
        if (num < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }
        
        if (num == 0 || num == 1)
        {
            return 1;
        }
        
        long factorial = 1;
        for (int i = 2; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter a number to find its factorial: ");
            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                long result = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
