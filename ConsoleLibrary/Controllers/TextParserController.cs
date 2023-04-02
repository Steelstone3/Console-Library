using System;
using System.Linq;
using System.Text.RegularExpressions;
using ConsoleLibrary.Controllers.Interfaces;

namespace ConsoleLibrary.Controllers
{
    public class TextParserController : ITextParserController
    {
        public string Read(string message)
        {
            string input = GetInput(message);
            Console.WriteLine(input);

            return input;
        }

        public string Read(string message, string regexString)
        {
            string input = GetInput(message);
            input = Regex.Replace(input, regexString, string.Empty);
            Console.WriteLine(input);

            return input;
        }

        private static string GetInput(string message)
        {
            Console.Write(message + " ");
            return Console.ReadLine();
        }

        public int Read(string message, int minimumValue, int maximumValue)
        {
            string input = GetInput(message);

            int value;
            while (!int.TryParse(input, out value) || IsLessThanMinimum(minimumValue, value) || IsGreaterThanMaximum(maximumValue, value))
            {
                if (input.Any(char.IsLetter))
                {
                    Console.WriteLine($"Error: Invalid input {input}");
                }
                else if (IsGreaterThanMaximum(maximumValue, value))
                {
                    Console.WriteLine($"Error: {input} is greater than {maximumValue}");
                }
                else
                {
                    Console.WriteLine($"Error: {input} is less than {minimumValue}");
                }

                input = GetInput(message);
            }

            Console.WriteLine(value);

            return value;
        }

        private static bool IsLessThanMinimum(int minimumValue, int value) => value < minimumValue;
        private static bool IsGreaterThanMaximum(int maximumValue, int value) => value > maximumValue;
    }
}