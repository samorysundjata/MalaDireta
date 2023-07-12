using MalaDireta.Context;
using MalaDireta.Controllers;
using MalaDireta.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Moq;

namespace MalaDiretaTests
{
    public class ClienteTests
    {
        private readonly AppDbContext _context;

        [Fact]
        public void Cliente_Testar_Um() 
        {
            //Arrange
            var cliente = new Cliente();

            //Act
            cliente.Nome = "Fulano de Tal";
            cliente.Email = "fulano@gmail.com";
            cliente.Telefone = "012346789";
            cliente.Endereco = new Endereco(
                    id: 1,
                    logradouro: "Texto",
                    cidade: "Texto",
                    estado: "DD",
                    cep: 123456
                );


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
                        "fulano@gmail.com",
                        new Endereco(
                            100,
                            "Texto",
                            "Texto",
                            "Texto",
                            12346
                            )
                );

            //Act
            var result = cliente;

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Post_ValidCliente_ReturnsCreatedAtRouteResult()
        {
            // Arrange
            var cliente = new Cliente
            {
                // Initialize the Cliente object with valid data for testing
                ClienteId = 1,
                // Set other properties accordingly
            };

            var mockContext = new Mock<AppDbContext>();
            // Configure the mock context as needed

            var controller = new ClienteController(mockContext.Object);

            // Act
            var result = controller.Post(cliente);

            // Assert
            var createdAtRouteResult = Assert.IsType<CreatedAtRouteResult>(result);
            Assert.Equal("ObterCliente", createdAtRouteResult.RouteName);
            Assert.Equal(cliente.ClienteId, createdAtRouteResult.RouteValues["id"]);
            Assert.Equal(cliente, createdAtRouteResult.Value);
        }        
    }
}
