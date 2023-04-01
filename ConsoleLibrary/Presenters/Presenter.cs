using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters.Interfaces;

namespace ConsoleLibrary.Presenters
{
    public class Presenter : IPresenter
    {
        private readonly IConsoleInterface consoleInterface;

        public Presenter()
        {
            consoleInterface = new ConsoleInterface();
        }

        public ITextPrinter TextPrinter => new TextPrinter(consoleInterface);
        public ITextParser TextParser => new TextParser();
    }
}
