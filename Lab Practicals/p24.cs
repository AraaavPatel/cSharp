using System;

class ATM
{
    static void Main()
    {
        int correctPin = 1234;
        decimal balance = 5000;
        int attempts = 3;

        Console.WriteLine("=== ATM System ===");
        
        // PIN Verification
        while (attempts > 0)
        {
            Console.Write("Enter PIN: ");
            if (int.TryParse(Console.ReadLine(), out int enteredPin))
            {
                if (enteredPin == correctPin)
                {
                    Console.WriteLine("PIN verified successfully!\n");
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Incorrect PIN. Attempts remaining: {attempts}\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine("Account locked due to multiple failed attempts.");
            return;
        }

        // Withdrawal Process
        Console.WriteLine($"Current Balance: ${balance}");
        Console.Write("Enter withdrawal amount: $");
        
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful! Remaining balance: ${balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance for this withdrawal.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}