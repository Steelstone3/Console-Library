using ConsoleLibrary.Controllers.Interfaces;
using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters;
using ConsoleLibrary.Presenters.Interfaces;
using Moq;
using Xunit;

namespace ConsoleLibraryTests.Presenters
{
    public class TextParserShould
    {
        private const string MESSAGE = "Hello";
        private readonly Mock<IConsoleInterface> consoleInterface = new();
        private readonly Mock<ITextParserController> textParserController = new();
        private readonly ITextParser textParser;

        public TextParserShould()
        {
            consoleInterface.Setup(ci => ci.TextParser).Returns(textParserController.Object);
            textParser = new TextParser(consoleInterface.Object);
        }

        [Fact(Skip="skip")]
        public void Read()
        {
            // Given

            // When

            // Then
        }
    }
}