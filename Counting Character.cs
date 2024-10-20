using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Prompt the user for input
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Create a dictionary to store character counts
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        // Loop through each character in the string
        foreach (char c in input)
        {
            // Convert to lower case to make it case-insensitive
            char lowerChar = char.ToLower(c);

            // Check if the character is alphabetic
            if (char.IsLetter(lowerChar))
            {
                // Update the count in the dictionary
                if (charCounts.ContainsKey(lowerChar))
                {
                    charCounts[lowerChar]++;
                }
                else
                {
                    charCounts[lowerChar] = 1; // Initialize count
                }
            }
        }

        // Print the results
        Console.WriteLine("\nCharacter counts:");
        foreach (var kvp in charCounts)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
}
