using System;
public class Account
{
    
    protected string accountHolder;
    protected double balance;

    public Account(string holder, double initialBalance)
    {
        accountHolder = holder;
        balance = initialBalance;
    }
    public string AccountHolder => accountHolder;
    public double Balance => balance;

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

public class SavingsAccount : Account
{
    private double interestRate;   

    public SavingsAccount(string holder, double initialBalance, double rate)
        : base(holder, initialBalance)   
    {
        interestRate = rate;
    }

    public void ApplyInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine($"Interest applied ({interestRate}%): +{interest:F2}. New Balance: {balance:F2}");
    }

    public override void DisplayBalance()
    {
        base.DisplayBalance();   
        Console.WriteLine($"Interest Rate : {interestRate}%");
        Console.WriteLine("-----------------------");
    }
}

public class CurrentAccount : Account
{
    private double overdraftLimit;   

    public CurrentAccount(string holder, double initialBalance, double limit)
        : base(holder, initialBalance)
    {
        overdraftLimit = limit;
    }

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

    public override void DisplayBalance()
    {
        base.DisplayBalance();
        Console.WriteLine($"Overdraft Limit : {overdraftLimit:F2}");
        Console.WriteLine("-----------------------");
    }
}

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

            savings.ApplyInterest();
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

        
        account.DisplayBalance();
    }
}