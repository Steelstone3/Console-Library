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
    }
}