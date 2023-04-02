using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters.Interfaces;

namespace ConsoleLibrary.Presenters
{
    public class TextParser : ITextParser
    {
        private readonly IConsoleInterface consoleInterface;

        public TextParser(IConsoleInterface consoleInterface)
        {
            this.consoleInterface = consoleInterface;
        }

        public string Read(string message) => consoleInterface.TextParser.Read(message);
        public string Read(string message, string regex) => consoleInterface.TextParser.Read(message, regex);
        public int Read(string message, int minimumValue, int maximumValue) => consoleInterface.TextParser.Read(message, minimumValue, maximumValue);
    }
}