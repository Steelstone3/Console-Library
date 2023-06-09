using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters;
using ConsoleLibrary.Presenters.Interfaces;

namespace BubblesDivePlanner
{
    internal static class Program
    {
        static void Main()
        {
            IPresenter presenter = new Presenter();
            presenter.TextPrinter.Print("Hello");
            presenter.TextPrinter.Print("Hello", Colour.RED);
            presenter.TextPrinter.Print("Hello", Colour.GREEN);
            presenter.TextPrinter.Print("Hello", Colour.YELLOW);
            presenter.TextPrinter.Print("Hello", Colour.BLUE);
            presenter.TextParser.Read("Enter Name:");
            presenter.TextParser.Read("Enter Name:", "[^0-9a-zA-Z]+");
            presenter.TextPrinter.Print("Hello", Colour.BLUE);
            presenter.TextParser.Read("Get Int32:", 1, 99);

            // string NL          = Environment.NewLine; // shortcut
            // string NORMAL      = Console.IsOutputRedirected ? "" : "\x1b[39m";
            // string RED         = Console.IsOutputRedirected ? "" : "\x1b[91m";
            // string GREEN       = Console.IsOutputRedirected ? "" : "\x1b[92m";
            // string YELLOW      = Console.IsOutputRedirected ? "" : "\x1b[93m";
            // string BLUE        = Console.IsOutputRedirected ? "" : "\x1b[94m";
            // string MAGENTA     = Console.IsOutputRedirected ? "" : "\x1b[95m";
            // string CYAN        = Console.IsOutputRedirected ? "" : "\x1b[96m";
            // string GREY        = Console.IsOutputRedirected ? "" : "\x1b[97m";
            // string BOLD        = Console.IsOutputRedirected ? "" : "\x1b[1m";
            // string NOBOLD      = Console.IsOutputRedirected ? "" : "\x1b[22m";
            // string UNDERLINE   = Console.IsOutputRedirected ? "" : "\x1b[4m";
            // string NOUNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[24m";
            // string REVERSE     = Console.IsOutputRedirected ? "" : "\x1b[7m";
            // string NOREVERSE   = Console.IsOutputRedirected ? "" : "\x1b[27m";

            // Console.WriteLine($"This is {RED}Red{NORMAL}, {GREEN}Green{NORMAL}, {YELLOW}Yellow{NORMAL}, {BLUE}Blue{NORMAL}, {MAGENTA}Magenta{NORMAL}, {CYAN}Cyan{NORMAL}, {GREY}Grey{NORMAL}! ");
            // Console.WriteLine($"This is {BOLD}Bold{NOBOLD}, {UNDERLINE}Underline{NOUNDERLINE}, {REVERSE}Reverse{NOREVERSE}! ");
        }
    }
}
