using MalaDireta.Models;

namespace MalaDiretaTests
{
    public class EnderecoTests
    {
        [Fact]
        public void Endereco_Testar_Um()
        {
            //Arrange
            var endereco = new Endereco();

            //Act
            endereco.Logradouro = "x";
            endereco.Cidade = "y";
            endereco.Estado = "x";
            endereco.CEP = 123465;

            //Assert
            Assert.NotNull(endereco);
        }
    }
}
