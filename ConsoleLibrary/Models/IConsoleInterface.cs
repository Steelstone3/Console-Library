using ConsoleLibrary.Controllers.Interfaces;

namespace ConsoleLibrary.Models
{
    public interface IConsoleInterface
    {
        ITextPrinterController TextPrinter { get; }
        ITextParserController TextParser { get; }
    }
}