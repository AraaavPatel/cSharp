using System;

string password = null;
Console.WriteLine("Enter paassword : ");
password = Console.ReadLine();

string entpass = null;
Console.WriteLine("Enter your password : ");
entpass = Console.ReadLine();

if (password == entpass)
    Console.WriteLine("Pass is correct");
else
    while (password != entpass)
    {
        Console.WriteLine("Pass is incorect");
        Console.WriteLine("Enter pass again : ");
        entpass = Console.ReadLine();

        if (password == entpass)
            Console.WriteLine("Pass is correct");
    }