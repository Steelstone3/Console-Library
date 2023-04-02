using ConsoleLibrary.Controllers;
using ConsoleLibrary.Controllers.Interfaces;

namespace ConsoleLibrary.Models
{
    public class ConsoleInterface : IConsoleInterface
    {
        public ITextPrinterController TextPrinter => new TextPrinterController();
        public ITextParserController TextParser => new TextParserController();
    }
}