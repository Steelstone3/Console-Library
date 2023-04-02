using ConsoleLibrary.Controllers;

namespace ConsoleLibrary.Models
{
    public class ConsoleInterface : IConsoleInterface
    {
        public ITextPrinterController TextPrinter => new TextPrinterController();
    }
}