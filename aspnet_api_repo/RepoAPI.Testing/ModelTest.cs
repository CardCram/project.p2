using Xunit;
using RepoAPI.Service.Models;

namespace RepoAPI.Testing {
    public class ModelTest {
        [Fact]
        private void Test_CardCramModelExists() {
            var sut = new CardCramModel();

            Assert.IsType<CardCramModel>(sut);
            Assert.NotNull(sut);
        }
    }
}