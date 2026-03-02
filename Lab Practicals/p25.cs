using System;

class ElectricityBillCalculator
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine());
        
        double billAmount = 0;
        
        // Calculate bill based on slabs
        if (units <= 100)
        {
            billAmount = units * 1.5;
        }
        else if (units <= 200)
        {
            billAmount = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            billAmount = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }
        
        // Add fixed meter charge
        billAmount += 50;
        
        // Apply GST if bill exceeds ₹500
        double gst = 0;
        if (billAmount > 500)
        {
            gst = billAmount * 0.18;
            billAmount += gst;
        }
        
        // Display results
        Console.WriteLine("\n--- Electricity Bill ---");
        Console.WriteLine($"Units Consumed: {units}");
        Console.WriteLine($"Bill Amount: ₹{billAmount - gst:F2}");
        Console.WriteLine($"GST (18%): ₹{gst:F2}");
        Console.WriteLine($"Total Bill: ₹{billAmount:F2}");
    }
}