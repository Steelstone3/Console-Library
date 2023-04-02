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
    }
}