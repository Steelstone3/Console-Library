namespace ConsoleLibrary.Presenters.Interfaces
{
    public interface IPresenter
    {
        ITextPrinter TextPrinter { get; }
        ITextParser TextParser { get; }
    }
}