using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        if (IsArmstrong(number))
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
    
    static bool IsArmstrong(int num)
    {
        int originalNum = num;
        int digitCount = num.ToString().Length;
        int sum = 0;
        
        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digitCount);
            num /= 10;
        }
        
        return sum == originalNum;
    }
}