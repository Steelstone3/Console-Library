using ConsoleLibrary.Controllers;

namespace ConsoleLibrary.Models
{
    public interface IConsoleInterface
    {
        ITextPrinterController TextPrinter { get; }
    }
}