using System;
using ConsoleLibrary.Models;

namespace ConsoleLibrary.Controllers
{
    public class TextPrinterController : ITextPrinterController
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteLine(string message, Colour colour)
        {
            switch (colour)
            {
                case Colour.RED:
                    WriteColouredLine(message, "\x1b[91m");
                    break;
                case Colour.YELLOW:
                    WriteColouredLine(message, "\x1b[93m");
                    break;
                case Colour.GREEN:
                    WriteColouredLine(message, "\x1b[92m");
                    break;
                case Colour.BLUE:
                    WriteColouredLine(message, "\x1b[94m");
                    break;
                default:
                    WriteColouredLine(message, "");
                    break;
            }
        }

        private static void WriteColouredLine(string message, string colourString)
        {
            const string normalColourString = "\x1b[39m";
            string normal = Console.IsOutputRedirected ? "" : normalColourString;
            string colour = Console.IsOutputRedirected ? "" : colourString;
            Console.WriteLine(colour + message + normal);
        }
    }
}