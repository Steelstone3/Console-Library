using ConsoleLibrary.Controllers.Interfaces;
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
        private readonly Mock<ITextPrinterController> textPrinterController = new();
        private readonly ITextPrinter textPrinter;

        public TextPrinterShould()
        {
            consoleInterface.Setup(ci => ci.TextPrinter).Returns(textPrinterController.Object);
            textPrinter = new TextPrinter(consoleInterface.Object);
        }

        [Fact]
        public void PrintMessage()
        {
            // Given
            textPrinterController.Setup(ci => ci.WriteLine(MESSAGE));

            // When
            textPrinter.Print(MESSAGE);

            // Then
            consoleInterface.VerifyAll();
        }

        [Fact]
        public void PrintColourfulAnsiColourMessage()
        {
            // Given
            textPrinterController.Setup(ci => ci.WriteLine(MESSAGE, Colour.RED));

            // When
            textPrinter.Print(MESSAGE, Colour.RED);

            // Then
            consoleInterface.VerifyAll();
        }
    }
}