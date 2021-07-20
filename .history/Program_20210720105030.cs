using System;
using System.Text.RegularExpressions;

namespace dotNetCore_july2021
{
    class Program
    {
        static void PrintIsValid(string input, string pattern)
        {
            Regex re = new Regex($@"{pattern}");

            Console.WriteLine($"{input} matches {pattern}: {re.IsMatch(input)}");
        }

        static void Main(string[] args)
        {

            ConsoleKeyInfo cki;

            while (true)
            {

                //Console.WriteLine("do something........");
                Console.WriteLine("The Default regular expression checks for at least one digit.");
                Console.Write("Enter a regular expression (or ENTER to use the default):");
                string pattern = Console.ReadLine();
                if (pattern == "")
                {
                    pattern = @"^[a-z]+$";
                }
                Console.Write("Enter some input: ");
                string input = Console.ReadLine();
                PrintIsValid(input, pattern);
                Console.WriteLine("Press ESC to end or any key to try again.");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}