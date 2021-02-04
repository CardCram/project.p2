using Xunit;
using CardCram.Domain.Models;

namespace CardCram.Testing {
    public class ModelTest {
        [Fact]
        private void Test_CardExists() {
            var sut = new Card();

            Assert.IsType<Card>(sut);
            Assert.NotNull(sut);
        }
        [Fact]
        private void Test_DeckExists() {
            var sut = new Deck();

            Assert.IsType<Deck>(sut);
            Assert.NotNull(sut);
        }
    }
}