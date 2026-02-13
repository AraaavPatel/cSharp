using System;

class Age
{
    static void Main()
    {
        int n;

        Console.WriteLine("Enter a value");
        n = int.Parse(Console.ReadLine());

        if (n < 1)
            Console.WriteLine("Entered value is Invalid.");
        else if (n >= 1 && n < 12)
            Console.WriteLine("you are Kid.");
        else if (n >= 12 && n < 18)
            Console.WriteLine("you are Teenager.");
        else if (n >= 18 && n < 60)
            Console.WriteLine("you are Adult.");
        else if (n > 60)
            Console.WriteLine("you are enior Citizen.");

    }

}