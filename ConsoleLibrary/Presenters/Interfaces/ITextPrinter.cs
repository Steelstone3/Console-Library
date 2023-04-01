using ConsoleLibrary.Models;

namespace ConsoleLibrary.Presenters.Interfaces
{
    public interface ITextPrinter
    {
        void Print(string message);
        void Print(string message, Colour colour);
    }
}