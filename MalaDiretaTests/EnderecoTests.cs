using MalaDireta.Models;
using Xunit;

namespace MalaDiretaTests
{
    public class EnderecoTests
    {
        [Fact(DisplayName = "Endereco_Testar_Um")]
        [Trait("Categoria", "EnderecoTests")]
        public void Endereco_Testar_Um()
        {
            //Arrange
            var endereco = new Endereco();

            //Act
            endereco.Logradouro = "x";
            endereco.Cidade = "y";
            endereco.Estado = "x";
            endereco.Bairro = "y";
            endereco.CEP = "123465";

            //Assert
            Assert.NotNull(endereco);
        }

        [Fact(DisplayName = "Endereco_Testar_Dois")]
        [Trait("Categoria", "EnderecoTests")]
        public void Endereco_Testar_Dois()
        {
            //Arrange
            var endereco = new Endereco(
                    1,
                    "x",
                    "z",
                    "y",
                    "RS",
                    "123456"
                );

            //Act
            var result = endereco;

            //Assert
            Assert.NotNull(result);
        }
    }
}
