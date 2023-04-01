using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters;
using ConsoleLibrary.Presenters.Interfaces;
using Moq;
using Xunit;

namespace ConsoleLibraryTests.Presenters
{
    public class TextPrinterShould
    {
        private const string MESSAGE = "Hello";
        private readonly Mock<IConsoleInterface> consoleInterface = new();
        private readonly ITextPrinter textPrinter;

        public TextPrinterShould()
        {
            textPrinter = new TextPrinter(consoleInterface.Object);
        }

        [Fact]
        public void PrintMessage()
        {
            // Given
            consoleInterface.Setup(ci => ci.WriteLine(MESSAGE));

            // When
            textPrinter.Print(MESSAGE);

            // Then
            consoleInterface.VerifyAll();
        }

        [Fact]
        public void PrintColourfulAnsiColourMessage()
        {
            // Given
            consoleInterface.Setup(ci => ci.WriteLine(MESSAGE, Colour.RED));

            // When
            textPrinter.Print(MESSAGE, Colour.RED);

            // Then
            consoleInterface.VerifyAll();
        }
    }
}