using ConsoleLibrary.Models;
using Xunit;

namespace ConsoleLibraryTests.Models
{
    public class ConsoleInterfaceShould
    {
        private readonly IConsoleInterface consoleInterface = new ConsoleInterface();

        [Fact]
        public void Initialises()
        {
            // Then
            Assert.NotNull(consoleInterface.TextPrinter);
        }
    }
}