using Xunit;
using CardCram.Client.Models;

namespace CardCram.Testing {
    public class ViewModelTest {
        [Fact]
        private void Test_CardViewModelExists() {
            var sut = new CardViewModel();

            Assert.IsType<CardViewModel>(sut);
            Assert.NotNull(sut);
        }
        [Fact]
        private void Test_DeckViewModelExists() {
            var sut = new DeckViewModel();

            Assert.IsType<DeckViewModel>(sut);
            Assert.NotNull(sut);
        }
    }
}