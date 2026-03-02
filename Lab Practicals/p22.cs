using System;

class BillCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Bill Calculator with Discount ===\n");
        
        Console.Write("Enter bill amount: $");
        double billAmount = double.Parse(Console.ReadLine());
        
        Console.WriteLine("\nCustomer Categories:");
        Console.WriteLine("1. Senior Citizen");
        Console.WriteLine("2. Regular");
        Console.WriteLine("3. Industrial");
        Console.Write("\nEnter customer category (1-3): ");
        int category = int.Parse(Console.ReadLine());
        
        double discountPercentage = 0;
        
        switch (category)
        {
            case 1:
                discountPercentage = 15; // Senior Citizen
                break;
            case 2:
                discountPercentage = 5; // Regular
                break;
            case 3:
                discountPercentage = 10; // Industrial
                break;
            default:
                Console.WriteLine("Invalid category!");
                return;
        }
        
        double discountAmount = (billAmount * discountPercentage) / 100;
        double finalBill = billAmount - discountAmount;
        
        Console.WriteLine("\n=== Bill Summary ===");
        Console.WriteLine($"Original Bill: ${billAmount:F2}");
        Console.WriteLine($"Discount: {discountPercentage}% (${discountAmount:F2})");
        Console.WriteLine($"Final Bill: ${finalBill:F2}");
    }
}