using ConsoleLibrary.Controllers;
using ConsoleLibrary.Models;
using ConsoleLibrary.Presenters;
using ConsoleLibrary.Presenters.Interfaces;
using Moq;
using Xunit;

namespace ConsoleLibraryTests.Presenters
{
    public class PresenterShould
    {
        private readonly IPresenter presenter;

        public PresenterShould()
        {
            presenter = new Presenter();
        }

        [Fact]
        public void Initialise()
        {
            // Then
            Assert.NotNull(presenter.TextPrinter);
            Assert.NotNull(presenter.TextParser);
        }
    }
}