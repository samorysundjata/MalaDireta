using MalaDireta.Services;
using Moq;
using Xunit;

namespace MalaDiretaTests
{
    public class ZipCodeTests
    {
        [Fact(DisplayName = "ValidateSearchByZipCode")]
        [Trait("Categoria", "ZipCodeTests")]
        public void ValidateSearchByZipCode()
        {
            // Arrange
            var fixtureResults = ResultsFixture.GetSampleResults();
            var clientMock = new Mock<IViaCepClient>();
            clientMock
                .Setup(c => c.Search(It.IsAny<string>()))
                .Returns(fixtureResults.First(r => r.ZipCode.Equals("12345-678")));

            // Act
            var result = clientMock.Object.Search("12345678");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Any", result.Unit);
            Assert.Equal("Rua Direita", result.Street);
            Assert.Equal(string.Empty, result.Complement);
            Assert.Equal(1, result.GIACode);
            Assert.Equal(1, result.IBGECode);
            Assert.Equal("Centro", result.Neighborhood);
            Assert.Equal("São Paulo", result.City);
            Assert.Equal("SP", result.StateInitials);
        }

        [Fact(DisplayName = "ValidateSearchByZipCodeAsync")]
        [Trait("Categoria", "ZipCodeTests")]
        public async Task ValidateSearchByZipCodeAsync()
        {
            // Arrange
            var fixtureResults = ResultsFixture.GetSampleResults();
            var clientMock = new Mock<IViaCepClient>();
            clientMock
                .Setup(c => c.SearchAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(fixtureResults.First(r => r.ZipCode.Equals("12345-678")));

            // Act
            var result = await clientMock.Object.SearchAsync("12345678", CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Any", result.Unit);
            Assert.Equal("Rua Direita", result.Street);
            Assert.Equal(string.Empty, result.Complement);
            Assert.Equal(1, result.GIACode);
            Assert.Equal(1, result.IBGECode);
            Assert.Equal("Centro", result.Neighborhood);
            Assert.Equal("São Paulo", result.City);
            Assert.Equal("SP", result.StateInitials);
        }

        [Fact(DisplayName = "ValidateSearchByZipCodeWithoutGiaCode")]
        [Trait("Categoria", "ZipCodeTests")]
        public void ValidateSearchByZipCodeWithoutGiaCode()
        {
            // Arrange
            var fixtureResults = ResultsFixture.GetSampleResults();
            var clientMock = new Mock<IViaCepClient>();
            clientMock
                .Setup(c => c.Search(It.IsAny<string>()))
                .Returns(fixtureResults.First(r => !r.GIACode.HasValue));

            // Act
            var result = clientMock.Object.Search("12345678");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("", result.Unit);
            Assert.Equal("Rua Direita", result.Street);
            Assert.Equal(string.Empty, result.Complement);
            Assert.Null(result.GIACode);
            Assert.Equal(1, result.IBGECode);
            Assert.Equal("Centro", result.Neighborhood);
            Assert.Equal("São Paulo", result.City);
            Assert.Equal("SP", result.StateInitials);
        }

        [Fact(DisplayName = "ValidateSearchByZipCodeWithoutGiaCodeAsync")]
        [Trait("Categoria", "Mudar")]
        public async Task ValidateSearchByZipCodeWithoutGiaCodeAsync()
        {
            // Arrange


            // Act

            // Assert

        }
    }
}
