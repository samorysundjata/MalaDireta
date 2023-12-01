using MalaDireta.Controllers;
using MalaDireta.Models;
using Microsoft.AspNetCore.Mvc;
using Moq.AutoMock;
using System.ComponentModel;
using Xunit;

namespace MalaDiretaTests.Controllers
{
    public class EnderecoControllerTests
    {
        readonly AutoMocker _mocker;
        readonly EnderecoController _controller;

        public EnderecoControllerTests()
        {
            _mocker = new AutoMocker();
            _controller = _mocker.CreateInstance<EnderecoController>();
        }

        [Fact(DisplayName = "Falhar Get")]
        [Trait("Category", "Fail")]
        public ActionResult FalharGet()
        {
            //Arrange
            //Act
            //Assert
        }
    }
}
