using Xunit;
using RepoAPI.Service.Controllers;

namespace RepoAPI.Testing {
    public class ControllerTest {
        [Fact]
        private void Test_CardCramControllerExists() {
            var sut = new CardCramController();

            Assert.IsType<CardCramController>(sut);
            Assert.NotNull(sut);
        }
    }
}