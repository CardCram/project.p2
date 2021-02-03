using Xunit;
using CardCram.Client.Controllers;

namespace CardCram.Testing {
    public class ControllerTest {
        [Fact]
        private void Test_CardControllerExists() {
            var sut = new CardController();

            Assert.IsType<CardController>(sut);
            Assert.NotNull(sut);
        }
        [Fact]
        private void Test_DeckControllerExists() {
            var sut = new DeckController();

            Assert.IsType<DeckController>(sut);
            Assert.NotNull(sut);
        }
    }
}