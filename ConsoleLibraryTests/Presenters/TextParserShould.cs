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
            const string expectedInput = "Some Input";
            textParserController.Setup(tpc => tpc.Read(MESSAGE)).Returns(expectedInput);

            // When
            string input = textParser.Read(MESSAGE);

            // Then
            consoleInterface.VerifyAll();
            Assert.NotEmpty(input);
        }

        [Fact]
        public void ReadStringWithRegex()
        {
            // Given
            const string expectedInput = "Some Input";
            const string regex = "Some Regex";
            textParserController.Setup(tpc => tpc.Read(MESSAGE, regex)).Returns(expectedInput);

            // When
            string input = textParser.Read(MESSAGE, regex);

            // Then
            consoleInterface.VerifyAll();
            Assert.NotEmpty(input);
        }

        [Fact]
        public void ReadInt32()
        {
            // Given
            const int expectedInput = 32;
            const int minimumValue = 2;
            const int maximumValue = 100;
            textParserController.Setup(tpc => tpc.Read(MESSAGE, minimumValue, maximumValue)).Returns(expectedInput);

            // When
            int input = textParser.Read(MESSAGE, minimumValue, maximumValue);

            // Then
            consoleInterface.VerifyAll();
        }
    }
}