using System.Diagnostics.Metrics;
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

        [Fact]
        public void ReadString()
        {
            // Given
            string expectedOutput = "Some Output";
            textParserController.Setup(tpc => tpc.Read(MESSAGE)).Returns(expectedOutput);

            // When
            string output = textParser.Read(MESSAGE);

            // Then
            consoleInterface.VerifyAll();
        }

        [Fact]
        public void ReadStringWithRegex()
        {
            // Given
            string expectedOutput = "Some Output";
            string regex = "Some Regex";
            textParserController.Setup(tpc => tpc.Read(MESSAGE, regex)).Returns(expectedOutput);

            // When
            string output = textParser.Read(MESSAGE, regex);

            // Then
            consoleInterface.VerifyAll();
        }
    }
}