using System;

class LoanEligibility
{
    static void Main()
    {
        Console.WriteLine("=== Loan Eligibility Checker ===");
        
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        if (!int.TryParse(ageInput, out int age))
        {
            Console.WriteLine("Invalid input for age. Please enter a whole number.");
            return;
        }

        Console.Write("Enter your annual income: ");
        string incomeInput = Console.ReadLine();
        if (!decimal.TryParse(incomeInput, out decimal income))
        {
            Console.WriteLine("Invalid input for income. Please enter a numeric value.");
            return;
        }

        Console.Write("Enter your credit score: ");
        string creditInput = Console.ReadLine();
        if (!int.TryParse(creditInput, out int creditScore))
        {
            Console.WriteLine("Invalid input for credit score. Please enter a whole number.");
            return;
        }
        
        // Nested conditions for loan eligibility
        if (age >= 21)
        {
            if (income >= 25000)
            {
                if (creditScore >= 650)
                {
                    Console.WriteLine("\n You are ELIGIBLE for the loan!");
                }
                else if (creditScore >= 600)
                {
                    Console.WriteLine("\n CONDITIONAL ELIGIBILITY: Your credit score is acceptable but lower than ideal.");
                }
                else
                {
                    Console.WriteLine("\n INELIGIBLE: Credit score is too low (minimum 600 required).");
                }
            }
            else
            {
                Console.WriteLine("\n INELIGIBLE: Annual income is too low (minimum $25,000 required).");
            }
        }
        else
        {
            Console.WriteLine("\n INELIGIBLE: You must be at least 21 years old.");
        }
    }
}