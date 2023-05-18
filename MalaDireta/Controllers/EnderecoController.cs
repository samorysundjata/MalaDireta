using MalaDireta.Context;
using MalaDireta.Models;
using Microsoft.AspNetCore.Mvc;

namespace MalaDireta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnderecoController : Controller
    {
        private readonly AppDbContext _context;

        public EnderecoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("enderecos")]
        public ActionResult<IEnumerable<Endereco>> GetEnderecos() 
        {
            try
            {
                var enderecos = _context.Clientes.ToList();
                if (!enderecos.Any()) { return NotFound("Endereços não encontrados"); }
                //Verificar se o retorno precisa ser Json mesmo.
                return Json(enderecos);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                               "Ocorreu um problema ao tratar a sua solicitação.");
            }
        }


    }
}
