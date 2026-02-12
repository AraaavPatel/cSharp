using System;

class CompoundInterestCalculator
{
    static void Main()
    {
        Console.WriteLine("Compound Interest Calculator");
        Console.WriteLine("============================\n");

        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (%): ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time Period (years): ");
        double time = double.Parse(Console.ReadLine());

        Console.Write("Enter Compounding Frequency (1=Annually, 2=Semi-annually, 4=Quarterly, 12=Monthly): ");
        int frequency = int.Parse(Console.ReadLine());

        double amount = principal * Math.Pow(1 + (rate / 100 / frequency), frequency * time);
        double compoundInterest = amount - principal;

        Console.WriteLine("\n============================");
        Console.WriteLine($"Principal: ${principal:F2}");
        Console.WriteLine($"Final Amount: ${amount:F2}");
        Console.WriteLine($"Compound Interest: ${compoundInterest:F2}");
    }
}