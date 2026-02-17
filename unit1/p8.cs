using System;

class OE
{
    static void Main()
    {
        int n;

        Console.WriteLine("Enter a value");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("Entered value is Even");
        else if (n % 2 == 1)
            Console.WriteLine("Entered value is Odd");

    }

}