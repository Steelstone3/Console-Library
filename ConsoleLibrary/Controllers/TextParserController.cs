using System;
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
    }
}