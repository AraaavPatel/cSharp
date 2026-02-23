using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        if (IsPalindrome(input))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
    
    static bool IsPalindrome(string str)
    {
        string cleaned = str.Replace(" ", "").ToLower();
        int left = 0;
        int right = cleaned.Length - 1;
        
        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
                return false;
            left++;
            right--;
        }
        
        return true;
    }
}