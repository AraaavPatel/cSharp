using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not a palindrome");
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