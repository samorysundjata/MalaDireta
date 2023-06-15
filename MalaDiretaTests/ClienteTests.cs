using MalaDireta.Models;

namespace MalaDiretaTests
{
    public class ClienteTests
    {
        [Fact]
        public void Cliente_Testar_Um() 
        {
            //Arrange
            var cliente = new Cliente();

            //Act
            cliente.Nome = "Fulano de Tal";
            cliente.Email = "fulano@gmail.com";
            cliente.Telefone = "012346789";


            //Assert
            Assert.NotNull(cliente);           

        }

        [Fact]
        public void Cliente_Testar_Dois()
        {
            //Arrange
            var cliente = new Cliente(
                        100,
                        "Fulano de Tal",
                        "2199725457",
                        "fulano@gmail.com"
                );

            //Act
            var result = cliente;

            //Assert
            Assert.NotNull(result);
        }
    }
}
