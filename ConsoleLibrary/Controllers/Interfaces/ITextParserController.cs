namespace ConsoleLibrary.Controllers.Interfaces
{
    public interface ITextParserController
    {
        string Read(string message);
        string Read(string message, string regex);
    }
}