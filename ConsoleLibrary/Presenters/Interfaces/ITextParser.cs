namespace ConsoleLibrary.Presenters.Interfaces
{
    public interface ITextParser
    {
        string Read(string message);
        string Read(string message, string regex);
    }
}