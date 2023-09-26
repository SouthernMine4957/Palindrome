using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        // Remove spaces and convert to lowercase
        input = input.Replace(" ", "").ToLower();

        // Compare the string with its reverse
        for (int i = 0, j = input.Length - 1; i < j; i++, j--)
        {
            if (input[i] != input[j])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
}
