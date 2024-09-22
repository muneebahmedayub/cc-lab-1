using System;
using System.Text.RegularExpressions;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the regex pattern for logical operators
            string pattern = @"(&&)|(\|\|)|(!)";
            Regex regex = new Regex(pattern);

            Console.WriteLine("Enter a string to check for logical operators:");
            string input = Console.ReadLine();

            // Check if the input contains logical operators
            Match match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine($"Found logical operator: {match.Value}");
            }
            else
            {
                Console.WriteLine("No logical operators found in the input.");
            }
        }
    }
}
