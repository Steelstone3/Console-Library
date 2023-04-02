using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters.Interfaces;

namespace ConsoleLibrary.Presenters
{
    public class TextPrinter : ITextPrinter
    {
        private readonly IConsoleInterface consoleInterface;

        public TextPrinter(IConsoleInterface consoleInterface)
        {
            this.consoleInterface = consoleInterface;
        }

        public void Print(string message) => consoleInterface.TextPrinter.WriteLine(message);
        public void Print(string message, Colour colour) => consoleInterface.TextPrinter.WriteLine(message, colour);
    }
}