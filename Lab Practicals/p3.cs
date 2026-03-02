using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate of Interest (%): ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time Period (years): ");
        double time = double.Parse(Console.ReadLine());
        
        double simpleInterest = (principal * rate * time) / 100;
        double totalAmount = principal + simpleInterest;
        
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Principal: {principal}");
        Console.WriteLine($"Simple Interest: {simpleInterest}");
        Console.WriteLine($"Total Amount: {totalAmount}");
    }
}