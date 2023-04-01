namespace ConsoleLibrary.Models
{
    public interface IConsoleInterface
    {
        void WriteLine(string message);
        void WriteLine(string message, Colour colour);
    }
}