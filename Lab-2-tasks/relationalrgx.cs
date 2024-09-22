using System;
using System.Text.RegularExpressions;

namespace RelationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the regex pattern for relational operators
            string pattern = @"(==)|(!=)|(<>)|(<=)|(>=)|(<)|(>)";
            Regex regex = new Regex(pattern);

            Console.WriteLine("Enter a string to check for relational operators:");
            string input = Console.ReadLine();

            // Check if the input contains relational operators
            Match match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine($"Found relational operator: {match.Value}");
            }
            else
            {
                Console.WriteLine("No relational operators found in the input.");
            }
        }
    }
}
