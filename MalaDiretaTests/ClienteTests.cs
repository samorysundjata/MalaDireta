using MalaDireta.Context;
using Microsoft.Extensions.Logging;

namespace MalaDiretaTests
{
    public class ClienteTests
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        //[Fact]
        //public void Cliente_Testar_Um()
        //{
        //    //Arrange
        //    var cliente = new Cliente();

        //    //Act
        //    cliente.Nome = "Fulano de Tal";
        //    cliente.Email = "fulano@gmail.com";
        //    cliente.Telefone = "012346789";
        //    cliente.Endereco = new Endereco(
        //            id: 1,
        //            logradouro: "Texto",
        //            cidade: "Texto",
        //            bairro: "Centro",
        //            estado: "DD",
        //            cep: "123456"
        //        );


        //    //Assert
        //    Assert.NotNull(cliente);

        //}

        //[Fact]
        //public void Cliente_Testar_Dois()
        //{
        //    //Arrange
        //    var cliente = new Cliente(
        //                100,
        //                "Fulano de Tal",
        //                "2199725457",
        //                "fulano@gmail.com",
        //                new Endereco(
        //                    100,
        //                    "Texto",
        //                    "Texto",
        //                    "Texto",
        //                    "Texto",
        //                    "12346"
        //                    )
        //        );

        //    //Act
        //    var result = cliente;

        //    //Assert
        //    Assert.NotNull(result);
        //}

        //[Fact]
        //public void Post_ValidCliente_ReturnsCreatedAtRouteResult()
        //{
        //    // Arrange
        //    var cliente = new Cliente
        //    {
        //        // Initialize the Cliente object with valid data for testing
        //        ClienteId = 1,
        //        // Set other properties accordingly
        //    };

        //    var mockContext = new Mock<AppDbContext>();
        //    // Configure the mock context as needed

        //    var controller = new ClienteController(mockContext.Object);

        //    // Act
        //    var result = controller.Post(cliente);

        //    // Assert
        //    var createdAtRouteResult = Assert.IsType<CreatedAtRouteResult>(result);
        //    Assert.Equal("ObterCliente", createdAtRouteResult.RouteName);
        //    Assert.Equal(cliente.ClienteId, createdAtRouteResult.RouteValues["id"]);
        //    Assert.Equal(cliente, createdAtRouteResult.Value);
        //}

        //[Fact]
        //public void GetClientes_DeveRetornarOkComClientesQuandoExistiremClientes()
        //{
        //    // Arrange
        //    var mockLogger = new Mock<ILogger<ClienteController>>(); // Substitua SuaClasseControladora pelo nome real da sua classe controladora
        //    var mockContext = new Mock<Cliente>(); // Substitua SeuContexto pelo nome real da sua classe de contexto
        //    var controller = new ClienteController(mockContext.Object, mockLogger.Object);

        //    // Adicione clientes fictícios ao contexto para simular dados no banco de dados
        //    mockContext.Setup(c => c. Cliente.AsNoTracking()).Returns(new List<Cliente>
        //{
        //    new Cliente { Id = 1, Nome = "Cliente1" },
        //    new Cliente { Id = 2, Nome = "Cliente2" },
        //}.AsQueryable());

        //    // Act
        //    var result = controller.GetClientes();

        //    // Assert
        //    var okResult = Assert.IsType<OkObjectResult>(result.Result);
        //    var clientes = Assert.IsType<List<Cliente>>(okResult.Value);
        //    Assert.Equal(2, clientes.Count);
        //}

        //[Fact]
        //public void GetClientes_DeveRetornarNotFoundQuandoNaoExistiremClientes()
        //{
        //    // Arrange
        //    var mockLogger = new Mock<ILogger<ClienteController>>(); 
        //    var mockContext = new Mock<Cliente>(); // Substitua SeuContexto pelo nome real da sua classe de contexto
        //    var controller = new ClienteController(AppDbContext mockContext.Object, mockLogger.Object);

        //    // Configure o contexto para retornar uma lista vazia de clientes
        //    mockContext.Setup(c => c.Clientes.AsNoTracking()).Returns(new List<Cliente>().AsQueryable());

        //    // Act
        //    var result = controller.GetClientes();

        //    // Assert
        //    Assert.IsType<NotFoundObjectResult>(result.Result);
        //}

    }
}
