using System;

// ─────────────────────────────────────────────
// BASE CLASS — encapsulates common account data
// ─────────────────────────────────────────────
public class Account
{
    // Instance variables (encapsulated as protected)
    protected string accountHolder;
    protected double balance;

    // Constructor
    public Account(string holder, double initialBalance)
    {
        accountHolder = holder;
        balance = initialBalance;
    }

    // Read-only properties (encapsulation)
    public string AccountHolder => accountHolder;
    public double Balance => balance;

    // virtual — allows derived classes to override
    public virtual void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }
        balance += amount;
        Console.WriteLine($"Deposited: {amount:F2}. New Balance: {balance:F2}");
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= 0 || amount > balance)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount:F2}. New Balance: {balance:F2}");
    }

    public virtual void DisplayBalance()
    {
        Console.WriteLine($"\n--- Account Details ---");
        Console.WriteLine($"Holder  : {accountHolder}");
        Console.WriteLine($"Balance : {balance:F2}");
    }
}


// ─────────────────────────────────────────────
// DERIVED CLASS 1 — SavingsAccount
//   Extra variable : interestRate
// ─────────────────────────────────────────────
public class SavingsAccount : Account
{
    private double interestRate;   // additional instance variable

    public SavingsAccount(string holder, double initialBalance, double rate)
        : base(holder, initialBalance)   // calls base constructor
    {
        interestRate = rate;
    }

    // New method specific to SavingsAccount
    public void ApplyInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine($"Interest applied ({interestRate}%): +{interest:F2}. New Balance: {balance:F2}");
    }

    // Method overriding — extends base DisplayBalance
    public override void DisplayBalance()
    {
        base.DisplayBalance();   // calls parent version first
        Console.WriteLine($"Interest Rate : {interestRate}%");
        Console.WriteLine("-----------------------");
    }
}


// ─────────────────────────────────────────────
// DERIVED CLASS 2 — CurrentAccount
//   Extra variable : overdraftLimit
// ─────────────────────────────────────────────
public class CurrentAccount : Account
{
    private double overdraftLimit;   // additional instance variable

    public CurrentAccount(string holder, double initialBalance, double limit)
        : base(holder, initialBalance)
    {
        overdraftLimit = limit;
    }

    // Method overriding — Withdraw behaves differently here
    public override void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }
        if (amount > balance + overdraftLimit)
        {
            Console.WriteLine($"Withdrawal of {amount:F2} exceeds overdraft limit. " +
                              $"Max allowed: {balance + overdraftLimit:F2}");
            return;
        }
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount:F2}. New Balance: {balance:F2}" +
                          (balance < 0 ? " (overdraft in use)" : ""));
    }

    // Method overriding — extends base DisplayBalance
    public override void DisplayBalance()
    {
        base.DisplayBalance();
        Console.WriteLine($"Overdraft Limit : {overdraftLimit:F2}");
        Console.WriteLine("-----------------------");
    }
}


// ─────────────────────────────────────────────
// TEST PROGRAM
// ─────────────────────────────────────────────
class Program
{
    static void Main()
    {
        Console.Write("Enter account type (savings / current): ");
        string accountType = Console.ReadLine()?.Trim().ToLower();

        Console.Write("Enter account holder name: ");
        string holder = Console.ReadLine()?.Trim();

        Console.Write("Enter initial balance: ");
        double initialBalance = double.Parse(Console.ReadLine()!);

        // Polymorphism — base-class reference holds either derived object
        Account account;

        if (accountType == "savings")
        {
            Console.Write("Enter interest rate (%): ");
            double rate = double.Parse(Console.ReadLine()!);

            SavingsAccount savings = new SavingsAccount(holder, initialBalance, rate);

            Console.Write("Enter deposit amount: ");
            savings.Deposit(double.Parse(Console.ReadLine()!));

            Console.Write("Enter withdrawal amount: ");
            savings.Withdraw(double.Parse(Console.ReadLine()!));

            savings.ApplyInterest();   // SavingsAccount-specific method
            account = savings;
        }
        else if (accountType == "current")
        {
            Console.Write("Enter overdraft limit: ");
            double limit = double.Parse(Console.ReadLine()!);

            CurrentAccount current = new CurrentAccount(holder, initialBalance, limit);

            Console.Write("Enter deposit amount: ");
            current.Deposit(double.Parse(Console.ReadLine()!));

            Console.Write("Enter withdrawal amount: ");
            current.Withdraw(double.Parse(Console.ReadLine()!));

            account = current;
        }
        else
        {
            Console.WriteLine("Invalid account type.");
            return;
        }

        // Polymorphic call — correct DisplayBalance() runs at runtime
        account.DisplayBalance();
    }
}