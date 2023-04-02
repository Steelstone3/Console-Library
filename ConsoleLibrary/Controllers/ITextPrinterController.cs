using ConsoleLibrary.Models;

namespace ConsoleLibrary.Controllers
{
    public interface ITextPrinterController
    {
        void WriteLine(string message);
        void WriteLine(string message, Colour colour);
    }
}